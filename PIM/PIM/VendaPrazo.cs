using PIM.ClassVenda;
using PIM.ClassVendaPrazo;
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
    public partial class VendaPrazo : Form
    {
        public VendaPrazo()
        {
            InitializeComponent();
            AtualizaTb();
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
        SelectVendaPrazo slcVp = new SelectVendaPrazo();
        public void AtualizaTb()
        {            
            dataGridView1.DataSource = slcVp.SelectVenda();
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 187;
        }
        Int32 id = 0;
        List<ClassProduto.Produto> p = new List<ClassProduto.Produto>();
        ClassProduto.SelectEditPro slcP = new ClassProduto.SelectEditPro();
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
                Int32 teste = Convert.ToInt32(row.Cells[1].Value);
                p = slcP.BuscarEditarProduto(teste);
                txtMarca.Text = p[0].marca.ToString();
                txtNome.Text = p[0].nome.ToString();
                txtValor.Text = p[0].valor.ToString();
                txtTamanho.Text = p[0].tamanho.ToString();
                txtCor.Text = p[0].cor.ToString();
            }
        }
        Picking pi = new Picking();
        private void EfetuarPicking_Click(object sender, EventArgs e)
        {
            pi.EfetuarPicking(id);
            AtualizaTb();
        }
    }
}
