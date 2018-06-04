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
    public partial class CadastrarPN : Form
    {
        public CadastrarPN()
        {
            InitializeComponent();
            Limpa();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Left = (w / 2) - 320;
            this.Top = 50;
            this.panel1.Left = (w / 2) - 492;


        }
        ClassPN.PN pn = new ClassPN.PN();
        ClassPN.InsertPN ispn = new ClassPN.InsertPN();
        private void btnCadColSalvar_Click(object sender, EventArgs e)
        {
            if(cadPNNome.Text != "" || cadPNCNPJ.Text != "" || cadPNRua.Text != "" || cadPNNum.Text != "" || cadPNBairro.Text != "" || cadPNCep.Text != "" || cadPNComplemento.Text != "" || cadPNCidade.Text != "" || cadPNEstado.Text != "" || cadPNPais.Text != "" || cadPNEmail.Text != "")
            {
                pn.rsocial = cadPNNome.Text;
                pn.cnpj = cadPNCNPJ.Text;
                pn.logradouro = cadPNRua.Text;
                pn.num = Convert.ToInt32(cadPNNum.Text);
                pn.bairro = cadPNBairro.Text;
                pn.cep = cadPNCep.Text;
                pn.complemento = cadPNComplemento.Text;
                pn.cidade = cadPNCidade.Text;
                pn.estado = cadPNEstado.Text;
                pn.pais = cadPNPais.Text;
                pn.email = cadPNEmail.Text;
                pn.dataCadastro = DateTime.Now;
                bool sc = ispn.SalvaPn(pn);
                if(sc)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                    Limpa();
                }
            }


        }

        private void btnCadColLimpar_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        public void Limpa()
        {
            cadPNNome.Text = "";
            cadPNCNPJ.Text = "";
            cadPNRua.Text = "";
            cadPNNum.Text = "";
            cadPNBairro.Text = "";
            cadPNCep.Text = "";
            cadPNComplemento.Text = "";
            cadPNCidade.Text = "";
            cadPNEstado.Text = "";
            cadPNPais.Text = "";
            cadPNEmail.Text = "";
        }

        private void btnCadColCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
