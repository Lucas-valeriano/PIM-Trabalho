using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassCompra
{
    public class LancamentoContabilCompra : ConectaDb
    {
        public void LCCompra(int id, Double d)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO contas_pagar (id_lc, valor, data) VALUES (@id_lc, @valor, @data);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_lc", id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("valor", d));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data", DateTime.Now));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro -> " + e);
            }
        }
    }
}
