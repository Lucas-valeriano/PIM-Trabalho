using MySql.Data.MySqlClient;
using PIM.ClassProduto;
using PIM.ClassVenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVendaPrazo
{
    public class SelectVendaPrazo : ConectaDb
    {
        public List<VP> SelectVenda()
        {
            List<VP> prod = new List<VP>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM venda_prazo WHERE status=0;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    VP p = new VP()
                    {
                        id_venda = Convert.ToInt32(leitor["id_venda"]),
                        id_produto = Convert.ToInt32(leitor["id_produto"]),
                        status = Convert.ToInt32(leitor["status"]),
                        id_compra = Convert.ToInt32(leitor["id_compra"])
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
