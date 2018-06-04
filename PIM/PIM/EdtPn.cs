using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.ClassPN;

namespace PIM
{
    public partial class EdtPn : Form
    {
        public EdtPn()
        {
            InitializeComponent();
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
        private void moveFrm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        ClassPN.SelectPn slc = new ClassPN.SelectPn();
        public void AtualizaData()
        {            
            dataGridView1.DataSource = slc.BuscaPn();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].HeaderText = "Razão social";
            dataGridView1.Columns[2].HeaderText = "CNPJ";
            dataGridView1.Columns[3].HeaderText = "Rua";
            dataGridView1.Columns[4].HeaderText = "Número";
            dataGridView1.Columns[5].HeaderText = "Bairro";
            dataGridView1.Columns[6].HeaderText = "CEP";
            dataGridView1.Columns[7].HeaderText = "Complemento";
            dataGridView1.Columns[8].HeaderText = "Cidade";
            dataGridView1.Columns[9].HeaderText = "Estado";
            dataGridView1.Columns[10].HeaderText = "Pais";
            dataGridView1.Columns[11].HeaderText = "E-mail";
            dataGridView1.Columns[12].HeaderText = "Data cadastro";
        }

        private void EdtPn_Load(object sender, EventArgs e)
        {
            AtualizaData();
        }


        int id = 0;  //<- ID GLOBAL
        ClassPN.SelectEditPn slcEdPn = new ClassPN.SelectEditPn();
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);

                List<PN> pn = slcEdPn.SelectPnEdit(id);

                cadPNNome.Text = pn[0].rsocial.ToString();
                cadPNCNPJ.Text = pn[0].cnpj.ToString();
                cadPNRua.Text = pn[0].logradouro.ToString();
                cadPNNum.Text = pn[0].num.ToString();
                cadPNBairro.Text = pn[0].bairro.ToString();
                cadPNCep.Text = pn[0].cep.ToString();
                cadPNComplemento.Text = pn[0].complemento.ToString();
                cadPNCidade.Text = pn[0].cidade.ToString();
                cadPNEstado.Text = pn[0].estado.ToString();
                cadPNPais.Text = pn[0].pais.ToString();
                cadPNEmail.Text = pn[0].email.ToString();
            }
        }

        ClassPN.DeletaPn delPn = new DeletaPn();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            delPn.ApagaPn(id);
            AtualizaData();
        }

        PN pc = new PN();
        ClassPN.AlteraPN altPn = new AlteraPN();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cadPNNome.Text != "" || cadPNCNPJ.Text != "" || cadPNRua.Text != "" || cadPNNum.Text != "" || cadPNBairro.Text != "" || cadPNCep.Text != "" || cadPNComplemento.Text != "" || cadPNCidade.Text != "" || cadPNEstado.Text != "" || cadPNPais.Text != "" || cadPNEmail.Text != "")
            {
                pc.idPn = id;
                pc.rsocial = cadPNNome.Text;
                pc.cnpj = cadPNCNPJ.Text;
                pc.logradouro = cadPNRua.Text;
                pc.num = Convert.ToInt32(cadPNNum.Text);
                pc.bairro = cadPNBairro.Text;
                pc.cep = cadPNCep.Text;
                pc.complemento = cadPNComplemento.Text;
                pc.cidade = cadPNCidade.Text;
                pc.estado = cadPNEstado.Text;
                pc.pais = cadPNPais.Text;
                pc.email = cadPNEmail.Text;
                bool res = altPn.AlteraPn(pc);
                if (res)
                {
                    AtualizaData();
                }
            }
        }
    }
}
