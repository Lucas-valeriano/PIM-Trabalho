using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassProduto
{
    class AlteraQuantidadeProduto : ConectaDb
    {
        public void AtualizaQuantidade(int id, int qtd)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "UPDATE produto SET quantidade=@quantidade WHERE id_produto=@id;";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", qtd));
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
