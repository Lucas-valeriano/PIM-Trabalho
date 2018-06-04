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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            atualizaTb();
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


        TrazVenda slcP = new TrazVenda();
        public void atualizaTb()
        {   

            dataGridView1.DataSource = slcP.SelectVenda();
            dataGridView1.Columns[0].HeaderText = "Nª  NFE";
            dataGridView1.Columns[0].Width = 74;
            dataGridView1.Columns[1].HeaderText = "DATA";
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[4].HeaderText = "";
        }


        List<ClassCliente.Cliente> cli = new List<ClassCliente.Cliente>();
        List<ClassColaborador.Colaborador> col = new List<ClassColaborador.Colaborador>();
        List<ClassPN.PN> pn = new List<ClassPN.PN>();


        ClassCliente.Cliente Tcli = new ClassCliente.Cliente();
        ClassColaborador.Colaborador Tcol = new ClassColaborador.Colaborador();
        ClassPN.PN Tpn = new ClassPN.PN();

        List<Produto> listP = new List<Produto>();
        ClassCliente.SelectEdit qCli = new ClassCliente.SelectEdit();
        ClassColaborador.SelectEditCo qCol = new ClassColaborador.SelectEditCo();
        ClassPN.SelectEditPn qPn = new ClassPN.SelectEditPn();
        GeradorNfe g = new GeradorNfe();

        IV iv = new IV();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var idVenda = row.Cells[0].Value;
                Int32 idv = Convert.ToInt32(idVenda);
                var idCliente = row.Cells[3].Value;
                var tipo = row.Cells[4].Value;
                int ti = 0;
                String tt = tipo.ToString();
                int idC = Convert.ToInt32(idCliente);
                if (tt == "Cli")
                {
                    ti = 1;
                    cli = qCli.BuscarEditarCliente(idC);
                    Tcli.nome = cli[0].nome;
                    Tcli.data_nascimento = cli[0].data_nascimento;
                    Tcli.sexo = cli[0].sexo;
                    Tcli.email = cli[0].email;
                    Tcli.logradouro = cli[0].logradouro;
                    Tcli.numero = cli[0].numero;
                    Tcli.bairro = cli[0].bairro;
                    Tcli.cep = cli[0].cep;
                    Tcli.complemento = cli[0].complemento;
                    Tcli.cidade = cli[0].cidade;
                    Tcli.estado = cli[0].estado;
                    Tcli.pais = cli[0].pais;
                    Tcli.cpf = cli[0].cpf;
                    Tcli.rg = cli[0].rg;
                    Tcli.ddd = cli[0].ddd;
                    Tcli.telefone = cli[0].telefone;
                    Tcli.celular = cli[0].celular;
                }
                else if (tt == "Col")
                {
                    ti = 2;
                    col = qCol.BuscarEditarColaborador(idC);

                    Tcol.nome = col[0].nome;
                    Tcol.dataNascimento = col[0].dataNascimento;
                    Tcol.sexo = col[0].sexo;
                    Tcol.ddd = col[0].ddd;
                    Tcol.tel = col[0].tel;
                    Tcol.cel = col[0].cel;
                    Tcol.email = col[0].email;
                    Tcol.logradouro = col[0].logradouro;
                    Tcol.num = col[0].num;
                    Tcol.bairro = col[0].bairro;
                    Tcol.cep = col[0].cep;
                    Tcol.complemento = col[0].complemento;
                    Tcol.cidade = col[0].cidade;
                    Tcol.estado = col[0].estado;
                    Tcol.pais = col[0].pais;
                    Tcol.cpf = col[0].cpf;
                    Tcol.rg = col[0].rg;
                    Tcol.ctps = col[0].ctps;
                    Tcol.pis = col[0].pis;
                    Tcol.dataContratacao = col[0].dataContratacao;
                    Tcol.idSetor = col[0].idSetor;
                    Tcol.salario = col[0].salario;
    }
                else if (tt == "PNe")
                {
                    ti = 3;
                    pn = qPn.SelectPnEdit(idC);


                    Tpn.idPn = pn[0].idPn;
                    Tpn.rsocial = pn[0].rsocial;
                    Tpn.cnpj = pn[0].cnpj;
                    Tpn.logradouro = pn[0].logradouro;
                    Tpn.num = pn[0].num;
                    Tpn.bairro = pn[0].bairro;
                    Tpn.cep = pn[0].cep;
                    Tpn.complemento = pn[0].complemento;
                    Tpn.cidade = pn[0].cidade;
                    Tpn.estado = pn[0].estado;
                    Tpn.pais = pn[0].pais;
                    Tpn.email = pn[0].email;
                    Tpn.dataCadastro = pn[0].dataCadastro;
    }
                listP =  iv.SelectP(idv);



                g.GerarNFE(Tcli, Tcol, Tpn, ti, listP, idv);



            }
        }
    }
}
