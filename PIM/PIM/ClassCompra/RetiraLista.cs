using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassCompra
{
    public class RetiraLista : ConectaDb
    {
        public void RemoveItemLista(int id, String pn, int qtd, Double d)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "UPDATE compra SET id_produto=@id_produto, quantidade=@quantidade, cpd=@cpd, pn=@pn, valor=@valor WHERE cpd=0;";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_produto", id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pn", pn));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", qtd));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpd", true));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("valor", d));

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
