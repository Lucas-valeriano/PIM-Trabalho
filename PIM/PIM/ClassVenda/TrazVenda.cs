using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class TrazVenda
    {
        public List<VN> SelectVenda()
        {
            List<VN> prod = new List<VN>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM venda;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    VN p = new VN()
                    {
                        id_venda_i = Convert.ToInt32(leitor["id_venda"]),
                        data_i = leitor["data"].ToString(),
                        id_comprador = Convert.ToInt32(leitor["id_comprador"]),
                        id_vendedor = Convert.ToInt32(leitor["id_vendedor"]),
                        comp = leitor["comp"].ToString()

                    };
                    prod.Add(p);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            return prod;
        }
    }
}
