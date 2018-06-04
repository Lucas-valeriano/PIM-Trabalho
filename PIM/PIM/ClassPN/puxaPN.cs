using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassPN
{
    public class puxaPN : ConectaDb
    {
        public List<PN> puxandoPN()
        {
            List<PN> parceiro = new List<PN>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM parceiro_negocio";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    PN p = new PN()
                    {
                        idPn = Convert.ToInt32(leitor["id_pn"]),
                        rsocial = Convert.ToString(leitor["razao_social"])
                    };
                    parceiro.Add(p);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return parceiro;
        }
    }
}
