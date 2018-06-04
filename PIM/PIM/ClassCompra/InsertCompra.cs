using MySql.Data.MySqlClient;
using PIM.ClassProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassCompra
{
    class InsertCompra : ConectaDb
    {
        public void SalvaCompra(Produto p)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO compra (id_produto, data_compra, cpd)VALUES(@id_produto, @data_compra, @cpd);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_produto", p.idPro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_compra", DateTime.Now));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpd", false));
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
