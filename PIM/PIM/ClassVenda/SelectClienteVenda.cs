using MySql.Data.MySqlClient;
using PIM.ClassCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class SelectClienteVenda : ConectaDb
    {
        public ClassCliente.Cliente PesquisaCliente(String cpf)
        {
            Cliente c = new Cliente();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM cliente WHERE cpf=@cpf";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    c.idCliente = Convert.ToInt32(leitor["id_cliente"]);
                    c.nome = Convert.ToString(leitor["nome"]);
                    c.data_nascimento = Convert.ToDateTime(leitor["data_nascimento"]);
                    c.sexo = Convert.ToString(leitor["sexo"]);
                    c.email = Convert.ToString(leitor["email"]);
                    c.logradouro = Convert.ToString(leitor["logradouro"]);
                    c.numero = Convert.ToInt32(leitor["numero"]);
                    c.bairro = Convert.ToString(leitor["bairro"]);
                    c.cep = Convert.ToString(leitor["cep"]);
                    c.complemento = Convert.ToString(leitor["complemento"]);
                    c.cidade = Convert.ToString(leitor["cidade"]);
                    c.estado = Convert.ToString(leitor["estado"]);
                    c.pais = Convert.ToString(leitor["pais"]);
                    c.cpf = Convert.ToString(leitor["cpf"]);
                    c.rg = Convert.ToString(leitor["rg"]);
                    c.data_cadastro = Convert.ToDateTime(leitor["data_cadastro"]);
                    c.ddd = Convert.ToInt32(leitor["ddd"]);
                    c.telefone = Convert.ToInt32(leitor["telefone"]);
                    c.celular = Convert.ToInt32(leitor["celular"]);
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
