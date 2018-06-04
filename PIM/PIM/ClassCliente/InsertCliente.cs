using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassCliente
{
    public class InsertCliente : ConectaDb
    {

        public bool SalvaCliente(Cliente c)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "INSERT INTO cliente (nome, data_nascimento, sexo, email, logradouro, numero, bairro, cep, complemento, cidade, estado, pais, cpf, rg, data_cadastro, ddd, telefone, celular)VALUES(@nome, @data_nascimento, @sexo, @email, @logradouro, @numero, @bairro, @cep, @complemento, @cidade, @estado, @pais, @cpf, @rg, @data_cadastro, @ddd, @telefone, @celular);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", c.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_nascimento", c.data_nascimento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("sexo", c.sexo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("email", c.email));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("logradouro", c.logradouro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("numero", int.Parse(c.numero.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro", c.bairro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", c.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("complemento", c.complemento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cidade", c.cidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("estado", c.estado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pais", c.pais));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf", c.cpf));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("rg", c.rg));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_cadastro", c.data_cadastro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ddd", int.Parse(c.ddd.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telefone", int.Parse(c.telefone.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", int.Parse(c.celular.ToString())));

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
    }
}
