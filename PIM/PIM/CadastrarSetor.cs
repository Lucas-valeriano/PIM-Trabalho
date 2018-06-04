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
    public partial class CadastrarSetor : Form
    {
        public CadastrarSetor()
        {
            InitializeComponent();
            AtualizaTabela();
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ClassSetor.Setor cs = new ClassSetor.Setor();
        ClassSetor.InsertSetor ise = new ClassSetor.InsertSetor();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cadFuncao.Text != "" || cadSetor.Text != "")
            {
            cs.funcao = cadFuncao.Text;
            cs.setor = cadSetor.Text;
            ise.SalvaCliente(cs);
            }
        }

        ClassSetor.PuxaSetor px = new ClassSetor.PuxaSetor();
        public void AtualizaTabela()
        {
            dataGridView1.DataSource = px.puxandoSetor();
        }
        int id = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }

        ClassSetor.ApagaSetor ap = new ClassSetor.ApagaSetor();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ap.ApagaSetores(id);
            AtualizaTabela();
        }
    }
}
