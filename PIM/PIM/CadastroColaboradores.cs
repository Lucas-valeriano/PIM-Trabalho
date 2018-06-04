using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class CadastroColaboradores : Form
    {
        public CadastroColaboradores()
        {
            InitializeComponent();
            AtualizaTabela();

            limpa();
            ClassSetor.PuxaSetor px = new ClassSetor.PuxaSetor();
            cadCoSetor.DataSource = px.puxandoSetor();
            cadCoSetor.DisplayMember = "setor";
            cadCoSetor.ValueMember = "id";



        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void MoveForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Left = (w / 2) - 320;
            this.Top = 50;
            this.panel1.Left = (w / 2) - 492;


        }
        Mascara objMask = new Mascara();


        private void FocusDataN(object sender, EventArgs e)
        {
            cadCoDtN.Mask = objMask.Dtn();
        }

        private void MaskCpf(object sender, EventArgs e)
        {
            cadCoCpf.Mask = objMask.Cpf();
        }

        private void MaskRg(object sender, EventArgs e)
        {
            cadCoRg.Mask = objMask.Rg();
        }

        private void MakTel(object sender, EventArgs e)
        {
            cadCoTel.Mask = objMask.Tel();
        }

        private void MaskCel(object sender, EventArgs e)
        {
            cadCoCel.Mask = objMask.Cel();
        }

        private void MaskCep(object sender, EventArgs e)
        {
            cadCoCep.Mask = objMask.Cep();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ClassColaborador.Colaborador c = new ClassColaborador.Colaborador();
        InsertColaborador sc = new InsertColaborador();
        private void btnCadColSalvar_Click(object sender, EventArgs e)
        {
            if (cadCoNome.Text != "" || cadCoDtN.Text != "" || cadCoSexo.Text != "" || cadCoDDD.Text != "" || cadCoTel.Text != "" || cadCoCel.Text != "" || cadCoEmail.Text != "" || cadCoRua.Text != "" || cadCoNum.Text != "" || cadCoBairro.Text != "" || cadCoCep.Text != "" || cadCoComplemento.Text != "" || cadCoCidade.Text != "" || cadCoEstado.Text != "" || cadCoPais.Text != "" || cadCoCpf.Text != "" || cadCoRg.Text != "" || cadCoCtps.Text != "" || cadCoPis.Text != "" || cadCoSetor.Text != "" || cadCoSalario.Text != "")
            {
                c.nome = cadCoNome.Text;
                c.dataNascimento = Convert.ToDateTime(cadCoDtN.Text);
                c.sexo = cadCoSexo.Text;
                c.ddd = Convert.ToInt32(cadCoDDD.Text);
                String ttel = cadCoTel.Text;
                ttel = ttel.Replace("-", "");
                c.tel = Convert.ToInt32(ttel);
                String tcel = cadCoCel.Text;
                tcel = tcel.Replace("-", "");
                c.cel = Convert.ToInt32(tcel);
                c.email = cadCoEmail.Text;
                c.logradouro = cadCoRua.Text;
                c.num = Convert.ToInt32(cadCoNum.Text);
                c.bairro = cadCoBairro.Text;
                c.cep = cadCoCep.Text;
                c.complemento = cadCoComplemento.Text;
                c.cidade = cadCoCidade.Text;
                c.estado = cadCoEstado.Text;
                c.pais = cadCoPais.Text;
                c.cpf = cadCoCpf.Text;
                c.rg = cadCoRg.Text;
                c.ctps = cadCoCtps.Text;
                c.pis = cadCoPis.Text;
                c.dataContratacao = DateTime.Now;
                c.idSetor = Convert.ToInt32(cadCoSetor.SelectedValue);
                c.salario = Convert.ToDouble(cadCoSalario.Text);
                bool ret = sc.SalvaColaborador(c);
                if (ret)
                {
                    MessageBox.Show("Colaborador salvo..");
                }
                AtualizaTabela();
            }
            
        }

        ClassColaborador.SelectColaborador trc = new ClassColaborador.SelectColaborador();
        public void AtualizaTabela()
        {
            dataGridView1.DataSource = trc.BuscarColaborador();
        }
        int id = 0;
        ClassColaborador.SelectEditCo slcEdCo = new ClassColaborador.SelectEditCo();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);


                
                List<ClassColaborador.Colaborador> p = slcEdCo.BuscarEditarColaborador(Convert.ToInt32(value));

                cadCoNome.Text = p[0].nome.ToString();

                String formatDat = p[0].dataNascimento.ToString();
                String tex = formatDat.Replace("00:00:00", "");
                cadCoDtN.Text = tex;
                cadCoDDD.Text = p[0].ddd.ToString();
                cadCoCel.Text = p[0].cel.ToString();
                cadCoCep.Text = p[0].cep.ToString();
                cadCoCidade.Text = p[0].cidade.ToString();
                cadCoCpf.Text = p[0].cpf.ToString();
                cadCoEmail.Text = p[0].email.ToString();
                cadCoBairro.Text = p[0].bairro.ToString();
                cadCoEstado.Text = p[0].estado.ToString();
                cadCoNum.Text = p[0].num.ToString();
                cadCoPais.Text = p[0].pais.ToString();
                cadCoRua.Text = p[0].logradouro.ToString();
                cadCoSexo.Text = p[0].sexo.ToString();
                cadCoTel.Text = p[0].tel.ToString();
                cadCoRg.Text = p[0].rg.ToString();                
                cadCoCtps.Text = p[0].ctps.ToString();
                cadCoPis.Text = p[0].pis.ToString();
                cadCoSalario.Text = p[0].salario.ToString();
                cadCoComplemento.Text = p[0].complemento.ToString();
                cadCoSetor.SelectionStart = Convert.ToInt32(p[0].idSetor);

            }
        }



        AlteraColaborador altc = new AlteraColaborador();
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cadCoNome.Text != "" || cadCoDtN.Text != "" || cadCoSexo.Text != "" || cadCoDDD.Text != "" || cadCoTel.Text != "" || cadCoCel.Text != "" || cadCoEmail.Text != "" || cadCoRua.Text != "" || cadCoNum.Text != "" || cadCoBairro.Text != "" || cadCoCep.Text != "" || cadCoComplemento.Text != "" || cadCoCidade.Text != "" || cadCoEstado.Text != "" || cadCoPais.Text != "" || cadCoCpf.Text != "" || cadCoRg.Text != "" || cadCoCtps.Text != "" || cadCoPis.Text != "" || cadCoSetor.Text != "" || cadCoSalario.Text != "")
            {
                c.idColaborador = id;
                c.nome = cadCoNome.Text;
                c.dataNascimento = Convert.ToDateTime(cadCoDtN.Text);
                c.sexo = cadCoSexo.Text;
                c.ddd = Convert.ToInt32(cadCoDDD.Text);
                String ttel = cadCoTel.Text;
                ttel = ttel.Replace("-", "");
                c.tel = Convert.ToInt32(ttel);
                String tcel = cadCoCel.Text;
                tcel = tcel.Replace("-", "");
                c.cel = Convert.ToInt32(tcel);
                c.email = cadCoEmail.Text;
                c.logradouro = cadCoRua.Text;
                c.num = Convert.ToInt32(cadCoNum.Text);
                c.bairro = cadCoBairro.Text;
                c.cep = cadCoCep.Text;
                c.complemento = cadCoComplemento.Text;
                c.cidade = cadCoCidade.Text;
                c.estado = cadCoEstado.Text;
                c.pais = cadCoPais.Text;
                c.cpf = cadCoCpf.Text;
                c.rg = cadCoRg.Text;
                c.ctps = cadCoCtps.Text;
                c.pis = cadCoPis.Text;
                c.dataContratacao = DateTime.Now;

                c.salario = Convert.ToDouble(cadCoSalario.Text);
                bool ret = altc.AlterColaborador(c);
                if (ret)
                {
                    MessageBox.Show("Colaborador alterado..");
                }
                AtualizaTabela();
            }

            
        }

        DeletaColaborador delco = new DeletaColaborador();
        private void btnCadColCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja apagar este colaborador?", "Apagar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delco.ApagaCol(id);
                AtualizaTabela();
            }
        }

        private void btnCadColLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }

        public void limpa()
        {
            cadCoNome.Text = "";
            cadCoDtN.Text = "";
            cadCoSexo.Text = "";
            cadCoDDD.Text = "";
            cadCoTel.Text = "";
            cadCoCel.Text = "";
            cadCoEmail.Text = "";
            cadCoRua.Text = "";
            cadCoNum.Text = "";
            cadCoBairro.Text = "";
            cadCoCep.Text = "";
            cadCoComplemento.Text = "";
            cadCoCidade.Text = "";
            cadCoEstado.Text = "";
            cadCoPais.Text = "";
            cadCoCpf.Text = "";
            cadCoRg.Text = "";
            cadCoCtps.Text = "";
            cadCoPis.Text = "";
            cadCoSetor.Text = ""; 
            cadCoSalario.Text = "";
        }
    }
}

