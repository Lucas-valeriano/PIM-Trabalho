using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassProduto
{
    public class DeletaProduto : ConectaDb
    {
        public void ApagaPro(int id)
        {
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "DELETE FROM produto WHERE id_produto=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
    }
}
