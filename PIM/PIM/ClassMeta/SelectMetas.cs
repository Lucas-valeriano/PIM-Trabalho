using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassMeta
{
    public class SelectMetas
    {        
        public List<Meta> BuscaMeta()
        {
            List<Meta> m = new List<Meta>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM meta";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Meta met = new Meta()
                    {
                        id = Convert.ToInt32(leitor["id_meta"]),
                        setor = Convert.ToInt32(leitor["id_setor"]),
                        comissao = Convert.ToInt32(leitor["comissao"]),
                        ano = Convert.ToInt32(leitor["ano"]),
                        mes = Convert.ToInt32(leitor["mes"])


                    };
                    m.Add(met);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro -> " + e);
            }
            return m;
        }
    }
}
