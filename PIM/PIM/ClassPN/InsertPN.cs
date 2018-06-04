using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassPN
{
    public class InsertPN : ConectaDb
    {


        public bool SalvaPn(PN p)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "INSERT INTO parceiro_negocio (razao_social, cnpj, logradouro, numero, bairro, cep, complemento, cidade, estado, pais, email, data_cadastro )VALUES( @razao_social, @cnpj, @logradouro, @num, @bairro, @cep, @complemento, @cidade, @estado, @pais, @email, @dataCadastro);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);

                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("razao_social", p.rsocial));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnpj", p.cnpj));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("logradouro", p.logradouro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("num", p.num));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro", p.bairro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", p.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("complemento", p.complemento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cidade", p.cidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("estado", p.estado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pais", p.pais));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("email", p.email));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dataCadastro", p.dataCadastro));


                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                return true;                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.ToString());
                return false;
            }
        }





        public List<PN> BuscaPn()
        {
            List<PN> lista = new List<PN>();

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
                    PN pn = new PN()
                    {
                        idPn = Convert.ToInt32(leitor["id_pn"]),
                        rsocial = leitor["razao_social"].ToString(),
                        cnpj = leitor["cnpj"].ToString(),
                        logradouro = leitor["razao_social"].ToString(),
                        num = Convert.ToInt32(leitor["numero"]),
                        bairro = leitor["bairro"].ToString(),
                        cep = leitor["cep"].ToString(),
                        complemento = leitor["complemento"].ToString(),
                        cidade = leitor["cidade"].ToString(),
                        estado = leitor["estado"].ToString(),
                        pais = leitor["pais"].ToString(),
                        email = leitor["email"].ToString(),
                        dataCadastro = Convert.ToDateTime(leitor["data_cadastro"])
                    };
                    lista.Add(pn);
                }
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro -> " + e.ToString());
            }


            return lista;
        }


    }
}
