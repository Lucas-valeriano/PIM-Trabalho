using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassPN
{
    public class SelectPn : ConectaDb
    {
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
                while(leitor.Read())
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

            }catch (Exception e)
            {
                Console.WriteLine("Erro -> " + e.ToString());
            }


            return lista;
        }
      
    }
}
