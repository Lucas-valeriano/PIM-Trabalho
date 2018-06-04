using PIM.ClassCliente;
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
    public partial class EditarCliente : Form
    {
        private SelectCliente slcCliente;
        private SelectEdit slcEdCli;
        public EditarCliente()
        {
            InitializeComponent();
            slcCliente = new SelectCliente();
            slcEdCli = new SelectEdit();

        }
        int id;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void moveFrm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Left = (w / 2) - 310;
            this.Top = 50;
            panel1.Left = (w / 2) - 472;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        
        private void EditarCliente_Load(object sender, EventArgs e)
        {
            AtualizaTb();


        }
        Cliente cl = new Cliente();
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);


                List<Cliente> p = slcEdCli.BuscarEditarCliente(Convert.ToInt32(value));                
                cadNome.Text = p[0].nome.ToString();

                String formatDat = p[0].data_nascimento.ToString();
                String tex = formatDat.Replace("00:00:00", "");
                cadDtN.Text = tex;
                cadDDD.Text = p[0].ddd.ToString();
                cadCel.Text = p[0].celular.ToString();
                cadCep.Text = p[0].cep.ToString();
                cadCidade.Text = p[0].cidade.ToString();
                cadCpf.Text = p[0].cpf.ToString();
                cadEmail.Text = p[0].email.ToString();
                cadBairro.Text = p[0].bairro.ToString();
                cadEstado.Text = p[0].estado.ToString();
                cadNum.Text = p[0].numero.ToString();
                cadPais.Text = p[0].pais.ToString();
                cadRua.Text = p[0].logradouro.ToString();
                cadSexo.Text = p[0].sexo.ToString();
                cadTel.Text = p[0].telefone.ToString();
                cadRg.Text = p[0].rg.ToString();

                

            }
        }


        AlteraCliente alc = new AlteraCliente();
        private void btnSalvar_Click(object sender, EventArgs e)
        {


            if (cadNome.Text == "" || cadDtN.Text == "" || cadSexo.Text == "" || cadEmail.Text == "" || cadRua.Text == "" || cadNum.Text == "" || cadBairro.Text == "" || cadCep.Text == "" || cadCidade.Text == "" || cadPais.Text == "" || cadDDD.Text == "" || cadCel.Text == "" || cadTel.Text == "" || cadRg.Text == "" || cadCpf.Text == "")
            {
                
            }
            else
            {
                Cliente c = new Cliente();
                c.nome = cadNome.Text;
                c.data_nascimento = Convert.ToDateTime(cadDtN.Text);
                c.ddd = Convert.ToInt32(cadDDD.Text);
                c.celular = Convert.ToInt32(cadCel.Text);
                c.cep = cadCep.Text;
                c.cidade = cadCidade.Text;
                c.cpf = cadCpf.Text;
                c.email = cadEmail.Text;
                c.bairro = cadBairro.Text;
                c.estado = cadEstado.Text;
                c.numero = Convert.ToInt32(cadNum.Text);
                c.pais = cadPais.Text;
                c.pais = cadRua.Text;
                c.sexo = cadSexo.Text;
                c.telefone = Convert.ToInt32(cadTel.Text);
                c.rg = cadRg.Text;
                c.idCliente = id;
                c.logradouro = cadRua.Text;

                alc.AlterCliente(c);
                AtualizaTb();
                limpa();
            }
            


        }

        DeletaCliente del = new DeletaCliente();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja apagar este contato?", "Apagar", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                del.ApagaCli(id);
                AtualizaTb();
            }

        }


        public void AtualizaTb()
        {
            dataGridView1.DataSource = slcCliente.BuscarCliente();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data Nasc.";
            dataGridView1.Columns[3].HeaderText = "Sexo";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].HeaderText = "Logradouro";
            dataGridView1.Columns[6].HeaderText = "Numero";
            dataGridView1.Columns[7].HeaderText = "Bairro";
            dataGridView1.Columns[8].HeaderText = "CEP";
            dataGridView1.Columns[9].HeaderText = "Complemento";
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].HeaderText = "Cidade";
            dataGridView1.Columns[11].HeaderText = "Estado";
            dataGridView1.Columns[12].HeaderText = "Pais";
            dataGridView1.Columns[13].HeaderText = "CPF";
            dataGridView1.Columns[14].HeaderText = "RG";
            dataGridView1.Columns[15].HeaderText = "Data Cadas.";
            dataGridView1.Columns[16].HeaderText = "DDD";
            dataGridView1.Columns[16].Width = 40;
            dataGridView1.Columns[17].HeaderText = "Telefone";
            dataGridView1.Columns[18].HeaderText = "Celular";
        }

        public void limpa()
        {
            cadNome.Text = "";
            cadDtN.Text = "";
            cadSexo.Text = "";
            cadEmail.Text = "";
            cadRua.Text = "";
            cadNum.Text = "";
            cadBairro.Text = "";
            cadCep.Text = "";
            cadCidade.Text = "";
            cadPais.Text = "";
            cadDDD.Text = "";
            cadCel.Text = "";
            cadTel.Text = "";
            cadRg.Text = "";
            cadCpf.Text = "";
        }

        
    }
}