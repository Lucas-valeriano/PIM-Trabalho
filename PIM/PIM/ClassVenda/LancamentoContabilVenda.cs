using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class LancamentoContabilVenda : ConectaDb
    {
        public void LCVenda(int id, Double d)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO contas_receber (id_venda, valor) VALUES (@id_venda, @valor);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_venda", id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("valor", d));
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
