using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class VendaSemProduto : ConectaDb
    {
        public void SalvaVenda100Produto(int idVen, int IdPro)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO venda_prazo (id_produto, status, id_compra) VALUES (@id_produto, @status, @id_compra);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);

                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_produto", IdPro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("status", false));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_compra", idVen));

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO ->" + e.ToString());
            }
        }
    }
}
