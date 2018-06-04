using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class Picking : ConectaDb
    {
        public void EfetuarPicking(int id)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "UPDATE venda_prazo SET status=@status WHERE id_venda=@id_venda;";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_venda", id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("status", 1));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.ToString());
            }
        }
    }
}
