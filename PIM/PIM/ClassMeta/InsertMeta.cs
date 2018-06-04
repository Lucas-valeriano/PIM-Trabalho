using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PIM.ClassMeta
{
    public class InsertMeta : ConectaDb
    {
        public bool SalvarMeta(Meta m)
        {

            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO meta (id_setor, comissao, ano, mes)VALUES(@id_setor, @comissao, @ano, @mes);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_setor", m.setor));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("comissao", m.comissao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ano", m.ano));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("mes", m.mes));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro -> "+ e);
                return false;
            }            
        }
    }
}
