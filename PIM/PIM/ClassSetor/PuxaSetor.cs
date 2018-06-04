using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassSetor
{
    public class PuxaSetor : ConectaDb
    {        
        public List<Setor> puxandoSetor()
        {
            List<Setor> setor = new List<Setor>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM setor";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Setor c = new Setor()
                    {
                        id = Convert.ToInt32(leitor["id_setor"]),
                        setor = Convert.ToString(leitor["setor"]),
                        funcao = Convert.ToString(leitor["funcao"])
                    };
                    setor.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            return setor;
        }

    }
}
