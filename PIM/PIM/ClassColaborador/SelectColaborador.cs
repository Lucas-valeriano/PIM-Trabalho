using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassColaborador
{
    public class SelectColaborador : ConectaDb
    {
        public List<Colaborador> BuscarColaborador()
        {
            List<Colaborador> colaborador = new List<Colaborador>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM colaborador";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Colaborador c = new Colaborador()
                    {
                        idColaborador = Convert.ToInt32(leitor["id_colaborador"]),
                        nome = Convert.ToString(leitor["nome"]),
                        dataNascimento = Convert.ToDateTime(leitor["data_nascimento"]),
                        sexo = Convert.ToString(leitor["sexo"]),
                        email = Convert.ToString(leitor["email"]),
                        logradouro = Convert.ToString(leitor["logradouro"]),
                        num = Convert.ToInt32(leitor["numero"]),
                        bairro = Convert.ToString(leitor["bairro"]),
                        cep = Convert.ToString(leitor["cep"]),
                        complemento = Convert.ToString(leitor["complemento"]),
                        cidade = Convert.ToString(leitor["cidade"]),
                        estado = Convert.ToString(leitor["estado"]),
                        pais = Convert.ToString(leitor["pais"]),
                        cpf = Convert.ToString(leitor["cpf"]),
                        rg = Convert.ToString(leitor["rg"]),
                        dataContratacao = Convert.ToDateTime(leitor["data_contratacao"]),
                        ddd = Convert.ToInt32(leitor["ddd"]),
                        tel = Convert.ToInt32(leitor["telefone"]),
                        pis = Convert.ToString(leitor["pis"]),
                        idSetor = Convert.ToInt32(leitor["id_setor"]),
                        ctps = Convert.ToString(leitor["ctps"]),
                        salario = Convert.ToDouble(leitor["salario"]),
                        cel = Convert.ToInt32(leitor["celular"])
                    };
                    colaborador.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());

            }
            return colaborador;
        }
    }
}
