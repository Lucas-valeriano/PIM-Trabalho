using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassPN
{
    public class AlteraPN
    {
        public bool AlteraPn(PN p)
        {

            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "UPDATE parceiro_negocio SET razao_social=@razao_social, cnpj=@cnpj, logradouro=@logradouro, numero=@numero, bairro=@bairro, cep=@cep, complemento=@complemento, cidade=@cidade, estado=@estado, pais=@pais, email=@email WHERE id_pn=@idPn;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("idPn", p.idPn));
                cmd.Parameters.Add(new MySqlParameter("razao_social", p.rsocial));
                cmd.Parameters.Add(new MySqlParameter("cnpj", p.cnpj));
                cmd.Parameters.Add(new MySqlParameter("logradouro", p.logradouro));
                cmd.Parameters.Add(new MySqlParameter("numero", p.num));
                cmd.Parameters.Add(new MySqlParameter("bairro", p.bairro));
                cmd.Parameters.Add(new MySqlParameter("cep", p.cep));
                cmd.Parameters.Add(new MySqlParameter("complemento", p.complemento));
                cmd.Parameters.Add(new MySqlParameter("cidade", p.cidade));
                cmd.Parameters.Add(new MySqlParameter("estado", p.estado));
                cmd.Parameters.Add(new MySqlParameter("pais", p.pais));
                cmd.Parameters.Add(new MySqlParameter("email", p.email));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();


                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro -> " + e);
                return false;
            }
            
        }
    }
}
