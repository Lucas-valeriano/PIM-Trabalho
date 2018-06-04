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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        ClassColaborador.LoginColaborador lgC = new ClassColaborador.LoginColaborador();
        ClassColaborador.Colaborador c = new ClassColaborador.Colaborador();
        private void button1_Click(object sender, EventArgs e)
        {
            c = lgC.Logando(senha.Text, email.Text);
            if (c.nome != null)
            {
                this.Hide();
                Form1 home = new Form1(c);
                home.Show();
            }
            else
            {
                MessageBox.Show("SENHA OU USUARIO INVALIDO!");
                email.Text = "";
                senha.Text = "";
            }
        }
    }
}
