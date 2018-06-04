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
    public partial class FundoPadrao : Form
    {
        public FundoPadrao()
        {
            InitializeComponent();            
        }
        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Left = (w / 2) - 310;
            this.Top = 50;
            panel1.Left = (w / 2) - 485;

        }

        Mascara objMask = new Mascara();
        ClassCliente.Cliente c = new ClassCliente.Cliente();
        ClassCliente.InsertCliente isc = new ClassCliente.InsertCliente();



        private void salvar_Click(object sender, EventArgs e)
        {
  
            


        }

        private void FundoPadrao_Load(object sender, EventArgs e)
        {

        }


        private void FocusDataN(object sender, EventArgs e)
        {
            cadDtN.Mask = objMask.Dtn();
        }

        private void MaskCpf(object sender, EventArgs e)
        {
            cadCpf.Mask = objMask.Cpf();
        }

        private void MaskRg(object sender, EventArgs e)
        {
            cadRg.Mask = objMask.Rg();
        }

        private void MakTel(object sender, EventArgs e)
        {
            cadTel.Mask = objMask.Tel();
        }

        private void MaskCel(object sender, EventArgs e)
        {
            cadCel.Mask = objMask.Cel();
        }

        private void MaskCep(object sender, EventArgs e)
        {
            cadCep.Mask = objMask.Cep();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampo())
            {
                c.nome = cadNome.Text;
                String d = cadDtN.Text + " 00:00:00";
                c.data_nascimento = Convert.ToDateTime(Convert.ToDateTime(d).ToString("yyyy-MM-dd HH:mm:ss"));
                c.sexo = cadSexo.Text;
                c.email = cadEmail.Text;
                c.logradouro = cadRua.Text;
                c.numero = Convert.ToInt32(cadNum.Text);
                c.bairro = cadBairro.Text;
                c.cep = cadCep.Text;
                c.complemento = cadComplemento.Text;
                c.cidade = cadCidade.Text;
                c.estado = cadEstado.Text;
                c.pais = cadPais.Text;
                c.ddd = Convert.ToInt32(cadDDD.Text);
                String cel = cadCel.Text;
                cel = cel.Replace("-", "");
                c.celular = Convert.ToInt32(cel);
                String tel = cadTel.Text;
                tel = tel.Replace("-", "");
                c.telefone = Convert.ToInt32(tel);
                c.rg = cadRg.Text;
                c.cpf = cadCpf.Text;
                string Date = DateTime.Now.ToShortDateString();
                c.data_cadastro = Convert.ToDateTime(Date);

                isc.SalvaCliente(c);
                limpa();
            }
            else
            {
                MessageBox.Show("Existem campos em branco!");
            }

        }




        public bool ValidaCampo()
        {
            if (cadNome.Text == "" || cadDtN.Text == "" ||
                cadSexo.Text == "" || cadEmail.Text == "" ||
                cadRua.Text == "" || cadNum.Text == "" ||
                cadBairro.Text == "" || cadCep.Text == "" ||
                cadComplemento.Text == "" || cadCidade.Text == "" ||
                cadEstado.Text == "" || cadPais.Text == "" ||
                cadDDD.Text == "" || cadCel.Text == "" ||
                cadTel.Text == "" || cadRg.Text == "" ||
                cadCpf.Text == "")
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpa();
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
            cadComplemento.Text = "";
            cadCidade.Text = "";
            cadEstado.Text = "";
            cadPais.Text = "";
            cadDDD.Text = "";
            cadCel.Text = "";
            cadTel.Text = "";
            cadRg.Text = "";
            cadCpf.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
