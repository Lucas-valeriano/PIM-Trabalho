using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIM
{
    public partial class Form1 : Form
    {
        ClassColaborador.Colaborador c = new ClassColaborador.Colaborador();
        public Form1(ClassColaborador.Colaborador col)
        {
            c = col;
            InitializeComponent();            
        }
        ClassCliente.InsertCliente ict = new ClassCliente.InsertCliente();
       

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda frm = new Venda(c);
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }


        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            panel2.Width = w;
            panel1.Width = w;
            panel2.Height = (h - 25);
        }

        private void cadastrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroColaboradores frm = new CadastroColaboradores();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void cadastrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroProdutos frm = new CadastroProdutos();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }



        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }



        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundoPadrao frm = new FundoPadrao();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente frm = new EditarCliente();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarPN frm = new CadastrarPN();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EdtPn frm = new EdtPn();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void cadastrarMetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMeta frm = new CadastroMeta();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void cadastrarSetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarSetor frm = new CadastrarSetor();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque frm = new Estoque();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void ordemDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdemCompra frm = new OrdemCompra();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void aReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void vendaPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaPrazo frm = new VendaPrazo();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senha frm = new Senha();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        public void Hierarquia(int i)
        {
            if (i == 1)
            {
                vendaPrazoToolStripMenuItem.Visible = true;
                novaVendaToolStripMenuItem.Visible = true;
                cadastrarToolStripMenuItem.Visible = true;
                editarToolStripMenuItem.Visible = true;
                vendaPrazoToolStripMenuItem.Visible = true;
                estoqueToolStripMenuItem1.Visible = true;
                cadastrarProdutoToolStripMenuItem2.Visible = true;
                ordemDeCompraToolStripMenuItem.Visible = true;
                cadastrarToolStripMenuItem1.Visible = true;
                editarToolStripMenuItem1.Visible = true;
                cadastrarUsuariosToolStripMenuItem.Visible = true;
                cadastrarSetorToolStripMenuItem.Visible = true;
                cadastrarMetasToolStripMenuItem.Visible = true;
            }
            else
            {

            }
        }

        private void carregado(object sender, EventArgs e)
        {
            Hierarquia(c.idSetor);
        }
    }
}
