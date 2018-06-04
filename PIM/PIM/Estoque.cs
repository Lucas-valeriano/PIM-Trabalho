using PIM.ClassProduto;
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
    public partial class Estoque : Form
    {
        public Estoque()
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
        private void moveFrm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SelectProduto slcP = new SelectProduto();
        public void AtualizaTb()
        {
            dataGridView1.DataSource =  slcP.BuscarProduto();


        }
    }
}
