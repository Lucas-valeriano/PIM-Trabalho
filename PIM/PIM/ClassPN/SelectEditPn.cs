using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassPN
{
    public class SelectEditPn : ConectaDb
    {
        public List<PN> SelectPnEdit(Int32 id)
        {
            int id_Pn = id;
            List<PN> parceiro = new List<PN>();

            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM parceiro_negocio WHERE id_pn=@id_pn";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_pn", id_Pn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    PN p = new PN()
                    {
                        rsocial = leitor["razao_social"].ToString(),
                        cnpj = leitor["cnpj"].ToString(),
                        logradouro = leitor["logradouro"].ToString(),
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
                    parceiro.Add(p);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());

            }

            return parceiro;
        }
    }
}
