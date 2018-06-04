using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PIM.ClassProduto;
using PIM.ClassVenda;
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
    public partial class Venda : Form
    {
        ClassColaborador.Colaborador c = new ClassColaborador.Colaborador();
        public Venda(ClassColaborador.Colaborador col)
        {
            InitializeComponent();
            c = col;
        }
        protected override void OnResize(EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Left = (w / 2) - 320;
            this.Top = 50;
            panel1.Left = (w / 2) - 488;



        }


        Mascara objMask = new Mascara();

        private void FocusDataN(object sender, EventArgs e)
        {
            VenCadDtN.Mask = objMask.Dtn();
        }

        private void MaskCpf(object sender, EventArgs e)
        {
            VenCadCpf.Mask = objMask.Cpf();
        }

        private void MaskRg(object sender, EventArgs e)
        {
            VenCadRg.Mask = objMask.Rg();
        }

        private void MakTel(object sender, EventArgs e)
        {
            VenCadTel.Mask = objMask.Tel();
        }

        private void MaskCel(object sender, EventArgs e)
        {
            VenCadCel.Mask = objMask.Cel();
        }

        private void MaskCep(object sender, EventArgs e)
        {
            VenCadCep.Mask = objMask.Cep();
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





        ClassCliente.Cliente cli = new ClassCliente.Cliente();
        ClassColaborador.Colaborador col = new ClassColaborador.Colaborador();
        ClassPN.PN p = new ClassPN.PN();

        ClassVenda.SelectClienteVenda slcCV = new ClassVenda.SelectClienteVenda();
        ClassVenda.SelectColaboradorVenda slcCoV = new ClassVenda.SelectColaboradorVenda();
        ClassVenda.SelectPNVenda slcPNV = new ClassVenda.SelectPNVenda();

        Int32 idC = 0;
        Int32 tC = 0;

        private void btnVenCadPesquisar_Click(object sender, EventArgs e)
        {
            if(tipo.Text == "" || tipo.Text == "CLIENTE")
            {
                tC = 1;
                cli = slcCV.PesquisaCliente(Convert.ToString(VenCadCpf.Text));
                VenCadNome.Text = cli.nome;
                VenCadRg.Text = cli.rg;
                VenCadDDD.Text = cli.ddd.ToString();
                VenCadRua.Text = cli.logradouro;
                VenCadNum.Text = cli.numero.ToString();
                VenCadCidade.Text = cli.cidade;
                VenCadDtN.Text = cli.cidade;
                VenCadCpf.Text = cli.cpf;
                VenCadTel.Text = cli.telefone.ToString();
                VenCadCel.Text = cli.celular.ToString();
                VenCadBairro.Text = cli.bairro;
                VenCadEstado.Text = cli.estado;
                VenCadEmail.Text = cli.email;
                VenCadCep.Text = cli.cep;
                VenCadSexo.Text = cli.sexo;
                VenCadPais.Text = cli.pais;
                idC = cli.idCliente;


                VenCadDDD.Enabled = true;
                VenCadSexo.Enabled = true;
                VenCadTel.Enabled = true;
                VenCadCel.Enabled = true;
                VenCadRg.Enabled = true;

            }
            else if (tipo.Text == "COLABORADOR")
            {
                tC = 2;
                col = slcCoV.BuscarColaborador(Convert.ToString(VenCadCpf.Text));
                VenCadNome.Text = col.nome;
                VenCadRg.Text = col.rg;
                VenCadDDD.Text = col.ddd.ToString();
                VenCadRua.Text = col.logradouro;
                VenCadNum.Text = col.num.ToString();
                VenCadCidade.Text = col.cidade;
                VenCadDtN.Text = col.cidade;
                VenCadCpf.Text = col.cpf;
                VenCadTel.Text = col.tel.ToString();
                VenCadCel.Text = col.cel.ToString();
                VenCadBairro.Text = col.bairro;
                VenCadEstado.Text = col.estado;
                VenCadEmail.Text = col.email;
                VenCadCep.Text = col.cep;
                VenCadSexo.Text = col.sexo;
                VenCadPais.Text = col.pais;
                idC = col.idColaborador;


                VenCadDDD.Enabled = true;
                VenCadSexo.Enabled = true;
                VenCadTel.Enabled = true;
                VenCadCel.Enabled = true;
                VenCadRg.Enabled = true;
            }
            else if (tipo.Text == "PARCEIRO DE NEGÓCIO")
            {
                tC = 3;
                p = slcPNV.SelectPnVenda(Convert.ToString(VenCadCpf.Text));
                VenCadNome.Text = p.rsocial;
                VenCadRua.Text = p.logradouro;
                VenCadNum.Text = p.num.ToString();
                VenCadCidade.Text = p.cidade;
                VenCadDtN.Text = p.cidade;
                VenCadCpf.Text = p.cnpj;
                VenCadBairro.Text = p.bairro;
                VenCadEstado.Text = p.estado;
                VenCadEmail.Text = p.email;
                VenCadCep.Text = p.cep;
                VenCadPais.Text = p.pais;
                idC = p.idPn;


                VenCadDDD.Enabled = false;
                VenCadSexo.Enabled = false;
                VenCadTel.Enabled = false;
                VenCadCel.Enabled = false;
                VenCadRg.Enabled = false;
            }
            
        }

        Produto pro = new Produto();
        List<Produto> Tpro = new List<Produto>();
        ClassVenda.SelectProdutoVenda slcProVen = new ClassVenda.SelectProdutoVenda();

        private void insere_Click(object sender, EventArgs e)
        {
            pro = slcProVen.BuscarProduto(Convert.ToInt32(txtInsere.Text));
            Tpro.Add(pro);
            AtualizaTb(Tpro);
            txtInsere.Text = "";
        }
        BindingSource bs = new BindingSource();
        public void AtualizaTb(List<Produto> l)
        {
            dt.DataSource = bs;
            dt.DataSource = l;
            dt.RowsDefaultCellStyle.BackColor = Color.White;
            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

        }

        ClassVenda.Venda v = new ClassVenda.Venda();
        ClassVenda.InsereVenda iv = new ClassVenda.InsereVenda();
        ClassVenda.InsereItem ii = new ClassVenda.InsereItem();
        GeradorNfe g = new GeradorNfe();
        private void finalizar_Click(object sender, EventArgs e)
        {
            v.id_vendedor = c.idColaborador;
            v.id_comprador = idC;
            v.data = Convert.ToString(DateTime.Now);
            if (tC == 1)
            {
                v.comp = "Cli";
            }
            else if (tC == 2)
            {
                v.comp = "Col";
            }
            else if (tC == 3)
            {
                v.comp = "PNe";
            }


                /*-- */
            Int32 idV = Convert.ToInt32(iv.SalvaVenda(v));
            ii.SalvaItem(Tpro, idV, idC);
            /*--*/
            g.GerarNFE(cli, col, p, tC, Tpro, idV);

            limpa();




        }

        private void btnVenCadLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }

        public void limpa()
        {
            VenCadNome.Text = "";
            VenCadRg.Text = "";
            VenCadDDD.Text = "";
            VenCadRua.Text = "";
            VenCadNum.Text = "";
            VenCadCidade.Text = "";
            VenCadDtN.Text = "";
            VenCadCpf.Text = "";
            VenCadTel.Text = "";
            VenCadCel.Text = "";
            VenCadBairro.Text = "";
            VenCadEstado.Text = "";
            VenCadEmail.Text = "";
            VenCadCep.Text = "";
            VenCadSexo.Text = "";
            VenCadPais.Text = "";
        }
    }
}
