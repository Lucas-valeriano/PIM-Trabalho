using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassMeta
{
    public class DeletaMeta : ConectaDb
    {
        public void ApagaMeta(int id)
        {
            int idct = id;
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "DELETE FROM meta WHERE id_meta=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", idct));
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
