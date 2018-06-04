using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassSetor
{
    public class InsertSetor : ConectaDb
    {
        public bool SalvaCliente(Setor s)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "INSERT INTO setor (setor, funcao)VALUES(@setor, @funcao);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("setor", s.setor));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("funcao", s.funcao));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.ToString());
                return false;
            }
        }
    }
}
