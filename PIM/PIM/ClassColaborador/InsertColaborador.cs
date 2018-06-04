using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public class InsertColaborador : ConectaDb
    {

        public bool SalvaColaborador(ClassColaborador.Colaborador c)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "INSERT INTO colaborador (nome, data_nascimento, sexo, ddd, telefone, celular, email, logradouro, numero, bairro, cep, complemento, cidade, estado, pais, cpf, rg, ctps, pis, data_contratacao, id_setor, salario )VALUES(@nome, @data_nascimento, @sexo, @ddd, @telefone, @celular, @email, @logradouro, @numero, @bairro, @cep, @complemento, @cidade, @estado, @pais, @cpf, @rg, @ctps, @pis, @data_contratacao, @id_setor, @salario );";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", c.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_nascimento", c.dataNascimento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("sexo", c.sexo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("email", c.email));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("logradouro", c.logradouro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("numero", int.Parse(c.num.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro", c.bairro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", c.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("complemento", c.complemento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cidade", c.cidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("estado", c.estado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pais", c.pais));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf", c.cpf));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("rg", c.rg));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_contratacao", c.dataContratacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ddd", int.Parse(c.ddd.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telefone", int.Parse(c.tel.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", int.Parse(c.cel.ToString())));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pis", c.pis));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ctps", c.ctps));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_setor", Convert.ToInt32(c.idSetor)));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("salario", Convert.ToDouble(c.salario)));


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
