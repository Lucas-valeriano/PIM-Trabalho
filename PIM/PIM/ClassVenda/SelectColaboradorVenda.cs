using MySql.Data.MySqlClient;
using PIM.ClassColaborador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class SelectColaboradorVenda : ConectaDb
    {
        public Colaborador BuscarColaborador(String cpf)
        {
            Colaborador c = new Colaborador();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM colaborador WHERE cpf=@cpf";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    c.idColaborador = Convert.ToInt32(leitor["id_colaborador"]);
                    c.nome = Convert.ToString(leitor["nome"]);
                    c.dataNascimento = Convert.ToDateTime(leitor["data_nascimento"]);
                    c.sexo = Convert.ToString(leitor["sexo"]);
                    c.email = Convert.ToString(leitor["email"]);
                    c.logradouro = Convert.ToString(leitor["logradouro"]);
                    c.num = Convert.ToInt32(leitor["numero"]);
                    c.bairro = Convert.ToString(leitor["bairro"]);
                    c.cep = Convert.ToString(leitor["cep"]);
                    c.complemento = Convert.ToString(leitor["complemento"]);
                    c.cidade = Convert.ToString(leitor["cidade"]);
                    c.estado = Convert.ToString(leitor["estado"]);
                    c.pais = Convert.ToString(leitor["pais"]);
                    c.cpf = Convert.ToString(leitor["cpf"]);
                    c.rg = Convert.ToString(leitor["rg"]);
                    c.dataContratacao = Convert.ToDateTime(leitor["data_contratacao"]);
                    c.ddd = Convert.ToInt32(leitor["ddd"]);
                    c.tel = Convert.ToInt32(leitor["telefone"]);
                    c.ctps = Convert.ToString(leitor["ctps"]);
                    c.pis = Convert.ToString(leitor["pis"]);
                    c.idSetor = Convert.ToInt32(leitor["id_setor"]);
                    c.salario = Convert.ToDouble(leitor["salario"]);
                    c.cel = Convert.ToInt32(leitor["celular"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            return c;
        }
    }
}
