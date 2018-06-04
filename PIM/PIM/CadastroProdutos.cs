using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace PIM
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
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
            if (w == 1016)
            {
                panel1.Left = (w / 2) - 495;
            }
            else
            {
                panel1.Left = (w / 2) - 495;
            }

        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ClassProduto.Produto p = new ClassProduto.Produto();
        ClassProduto.InsertProduto ip = new ClassProduto.InsertProduto();
        private void btnCadProSalvar_Click(object sender, EventArgs e)
        {
            if (CadProMarca.Text != "" || CadProNome.Text != "" || CadProQtd.Text != "" || cadProValor.Text != "" || cadProDesc.Text != "" || cadProCB.Text != "" || cadPproFt.Text != "" || CadProCor.Text != "" || CadProTamanho.Text != "" || CadProQtdMin.Text != "")
            {
                p.marca = CadProMarca.Text;
                p.nome = CadProNome.Text;
                p.qtd = Convert.ToInt32(CadProQtd.Text);
                p.valor = Convert.ToDouble(cadProValor.Text);
                p.desconto = Convert.ToDouble(cadProDesc.Text);
                p.codigo = Convert.ToInt32(cadProCB.Text);
                p.foto = cadPproFt.Text;
                p.cor = CadProCor.Text;
                p.tamanho = CadProTamanho.Text;
                p.dataCadastro = DateTime.Now;
                p.qtdMin = Convert.ToInt32(CadProQtdMin.Text);
                bool rp = ip.SalvaProduto(p);
                if (rp)
                {
                    MessageBox.Show("Produto Salvo..");
                    limpa();
                }
                AtualizaTabela();
            }

        }
        Int32 id = 0;

        ClassProduto.SelectProduto slcP = new ClassProduto.SelectProduto();
        public void AtualizaTabela()
        {
            dataGridView1.DataSource = slcP.BuscarProduto();
        }

        ClassProduto.DeletaProduto delP = new ClassProduto.DeletaProduto();
        private void btnCadProCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja apagar este Produto?", "Apagar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delP.ApagaPro(id);
                AtualizaTabela();
            }
        }
        
        ClassProduto.SelectEditPro slcEdP = new ClassProduto.SelectEditPro();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
                List<ClassProduto.Produto> p = slcEdP.BuscarEditarProduto(id);
                CadProMarca.Text = p[0].marca.ToString();
                CadProNome.Text = p[0].nome.ToString();
                CadProQtd.Text = p[0].qtd.ToString();
                cadProValor.Text = p[0].valor.ToString();
                cadPproFt.Text = p[0].foto.ToString();
                cadProCB.Text = p[0].codigo.ToString();
                cadProDesc.Text = p[0].desconto.ToString();
                CadProTamanho.Text = p[0].tamanho.ToString();
                CadProQtdMin.Text = p[0].qtdMin.ToString();
                CadProCor.Text = p[0].cor.ToString();
            }

        }

        ClassProduto.AlteraProduto alP = new ClassProduto.AlteraProduto();
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (CadProMarca.Text != "" || CadProNome.Text != "" || CadProQtd.Text != "" || cadProValor.Text != "" || cadProDesc.Text != "" || cadProCB.Text != "" || cadPproFt.Text != "" || CadProCor.Text != "" || CadProTamanho.Text != "" || CadProQtdMin.Text != "")
            {
                p.idPro = id;
                p.marca = CadProMarca.Text;
                p.nome = CadProNome.Text;
                p.qtd = Convert.ToInt32(CadProQtd.Text);
                p.valor = Convert.ToDouble(cadProValor.Text);
                p.desconto = Convert.ToDouble(cadProDesc.Text);
                p.codigo = Convert.ToInt32(cadProCB.Text);
                p.foto = cadPproFt.Text;
                p.cor = CadProCor.Text;
                p.tamanho = CadProTamanho.Text;
                p.dataCadastro = DateTime.Now;
                p.qtdMin = Convert.ToInt32(CadProQtdMin.Text);
                bool rp = alP.AtualizaProduto(p);
                if (rp)
                {
                    MessageBox.Show("Produto Atualizado..");
                    AtualizaTabela();
                    limpa();
                }
            }
        }

        private void btnCadProLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }


        public void limpa()
        {
            CadProMarca.Text = "";
            CadProNome.Text = "";
            CadProQtd.Text = "";
            cadProValor.Text = "";
            cadProDesc.Text = "";
            cadProCB.Text = "";
            cadPproFt.Text = "";
            CadProCor.Text = "";
            CadProTamanho.Text = "";
            CadProQtdMin.Text = "";
        }
    }
}
