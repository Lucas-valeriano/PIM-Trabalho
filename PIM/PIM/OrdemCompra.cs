using PIM.ClassCompra;
using PIM.ClassPN;
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
    public partial class OrdemCompra : Form
    {
        public OrdemCompra()
        {
            InitializeComponent();
            AtualizaTb();

            txbIdProduto.Enabled = false;            

            puxaPN px = new puxaPN();
            cbPn.DataSource = px.puxandoPN();
            cbPn.DisplayMember = "rsocial";
            cbPn.ValueMember = "idPN";
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

        CompraProduto slcP = new CompraProduto();
        public void AtualizaTb()
        {
            dataGridView1.DataSource = slcP.BuscarProduto();
        }
        Int32 id = 0;
        List<Produto> pecp = new List<Produto>();
        SelectEditPro prePro = new SelectEditPro();


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
                txbIdProduto.Text = id.ToString();
                pecp = prePro.BuscarEditarProduto(id);
            }
        }

        RetiraLista rtl = new RetiraLista();
        AlteraQuantidadeProduto altq = new AlteraQuantidadeProduto();
        LancamentoContabilCompra lcc = new LancamentoContabilCompra();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbIdProduto.Text != "" || txbQuantidade.Text != "" || txbValor.Text != "")
            {
                int qtdR = pecp[0].qtd + Convert.ToInt32(txbQuantidade.Text);
                altq.AtualizaQuantidade(Convert.ToInt32(txbIdProduto.Text), qtdR);
                rtl.RemoveItemLista(Convert.ToInt32(txbIdProduto.Text), Convert.ToString(cbPn.SelectedValue), Convert.ToInt32(txbQuantidade.Text), Convert.ToDouble(txbValor.Text));
                Int32 q = Convert.ToInt32(txbQuantidade.Text);
                Double v = Convert.ToDouble(txbValor.Text);
                Double dv = q * v ;
                lcc.LCCompra(Convert.ToInt32(txbIdProduto.Text), dv);
            }
            else
            {
                MessageBox.Show("Existem campos em branco!");
            }
        }
    }
}
