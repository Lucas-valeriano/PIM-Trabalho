using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassPN
{
    public class DeletaPn
    {
        public void ApagaPn(int idPa)
        {
            int idP = idPa;
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "DELETE FROM parceiro_negocio WHERE id_pn=@id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("id", idP));
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
