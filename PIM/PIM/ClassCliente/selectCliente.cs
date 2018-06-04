using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassCliente
{
    public class SelectCliente: ConectaDb
    {
        public List<Cliente> BuscarCliente()
        {
            List<Cliente> cliente = new List<Cliente>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM cliente";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while(leitor.Read())
                {
                    Cliente c = new Cliente()
                    {
                        idCliente = Convert.ToInt32(leitor["id_cliente"]),
                        nome = Convert.ToString(leitor["nome"]),
                        data_nascimento = Convert.ToDateTime(leitor["data_nascimento"]),
                        sexo = Convert.ToString(leitor["sexo"]),
                        email = Convert.ToString(leitor["email"]),
                        logradouro = Convert.ToString(leitor["logradouro"]),
                        numero = Convert.ToInt32(leitor["numero"]),
                        bairro = Convert.ToString(leitor["bairro"]),
                        cep = Convert.ToString(leitor["cep"]),
                        complemento = Convert.ToString(leitor["complemento"]),
                        cidade = Convert.ToString(leitor["cidade"]),
                        estado = Convert.ToString(leitor["estado"]),
                        pais = Convert.ToString(leitor["pais"]),
                        cpf = Convert.ToString(leitor["cpf"]),
                        rg = Convert.ToString(leitor["rg"]),
                        data_cadastro = Convert.ToDateTime(leitor["data_cadastro"]),
                        ddd = Convert.ToInt32(leitor["ddd"]),
                        telefone = Convert.ToInt32(leitor["telefone"]),
                        celular = Convert.ToInt32(leitor["celular"])
                    };
                    cliente.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
                
            }
            return cliente;
        }

    }
}
