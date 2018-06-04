using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassColaborador
{
    class AlteraSenha : ConectaDb
    {
        public bool AlterSenhaColaborador(String senha, Int32 idColaborador)
        {
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "UPDATE colaborador SET senha=@senha WHERE id_colaborador=@idColaborador;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("idColaborador", idColaborador));
                cmd.Parameters.Add(new MySqlParameter("senha", senha));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.ToString());
                return false;
            }

        }
    }
}
