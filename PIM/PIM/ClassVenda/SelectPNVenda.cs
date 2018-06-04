using MySql.Data.MySqlClient;
using PIM.ClassPN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class SelectPNVenda : ConectaDb
    {
        public PN SelectPnVenda(String cnpj)
        {
            ClassPN.PN p = new PN();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM parceiro_negocio WHERE cnpj=@cnpj";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    p.rsocial = leitor["razao_social"].ToString();
                    p.cnpj = leitor["cnpj"].ToString();
                    p.logradouro = leitor["logradouro"].ToString();
                    p.num = Convert.ToInt32(leitor["numero"]);
                    p.bairro = leitor["bairro"].ToString();
                    p.cep = leitor["cep"].ToString();
                    p.complemento = leitor["complemento"].ToString();
                    p.cidade = leitor["cidade"].ToString();
                    p.estado = leitor["estado"].ToString();
                    p.pais = leitor["pais"].ToString();
                    p.email = leitor["email"].ToString();
                    p.dataCadastro = Convert.ToDateTime(leitor["data_cadastro"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            return p;
        }
    }
}
