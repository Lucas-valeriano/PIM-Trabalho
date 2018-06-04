using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassCliente
{
    public class DeletaCliente : ConectaDb
    {

        public void ApagaCli(int idC)
        {
            int idct = idC;
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "DELETE FROM cliente WHERE id_cliente=@id;";
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
