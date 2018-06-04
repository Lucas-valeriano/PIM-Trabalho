using PIM.ClassSetor;
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
    public partial class CadastroMeta : Form
    {
        public CadastroMeta()
        {
            InitializeComponent();
            AtualizaTabela();

            ClassSetor.PuxaSetor px = new ClassSetor.PuxaSetor();
            CBBsetor.DataSource = px.puxandoSetor();
            CBBsetor.DisplayMember = "funcao";
            CBBsetor.ValueMember = "id";

            ClassMeta.PuxarAno a = new ClassMeta.PuxarAno();
            cbbAno.DataSource = a.PuxeAno();
            cbbAno.DisplayMember = "ano";
            cbbAno.ValueMember = "ano";


            ClassMeta.ValorComissao co = new ClassMeta.ValorComissao();
            cbbcomissao.DataSource = co.PuxaComissao();
            cbbcomissao.DisplayMember = "porcentagem";
            cbbcomissao.ValueMember = "porcentagem";

            ClassMeta.PuxarMeses m = new ClassMeta.PuxarMeses();
            cbbmes.DataSource = m.PuxandoMeses();
            cbbmes.DisplayMember = "mes";
            cbbmes.ValueMember = "mes";
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
        ClassMeta.Meta m = new ClassMeta.Meta();
        ClassMeta.InsertMeta im = new ClassMeta.InsertMeta();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(CBBsetor.Text != "" || cbbcomissao.Text != "" || cbbAno.Text != "" || cbbmes.Text != "")
            {
                m.setor = Convert.ToInt32(CBBsetor.SelectedValue);
                m.comissao = Convert.ToInt32(cbbcomissao.SelectedValue);
                m.ano = Convert.ToInt32(cbbAno.SelectedValue);
                m.mes = Convert.ToInt32(cbbmes.SelectedValue);
                bool ret = im.SalvarMeta(m);
                if(ret)
                {
                    AtualizaTabela();
                }
            }

        }

        ClassMeta.SelectMetas meta = new ClassMeta.SelectMetas();
        public void AtualizaTabela()
        {
            dataGridView1.DataSource = meta.BuscaMeta();
            dataGridView1.Columns[0].HeaderText = "Setor";
            dataGridView1.Columns[1].HeaderText = "Comissão";
            dataGridView1.Columns[2].HeaderText = "Ano";
            dataGridView1.Columns[3].HeaderText = "Mês";
        }

        Int32 id = 0;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var value = row.Cells[0].Value;
                id = Convert.ToInt32(value);
            }
        }

        ClassMeta.DeletaMeta del = new ClassMeta.DeletaMeta();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(id != 0)
            {
                del.ApagaMeta(id);
                AtualizaTabela();
            }
        }
    }
}
