using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassCompra
{
    public class checkItemCompra : ConectaDb
    {
        int vc = 0;
        public bool checkCompra(int id)
        {
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM compra WHERE id_produto=@id AND cpd=@cnd";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cnd", 0);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    vc += 1;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());

            }
            if (vc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
