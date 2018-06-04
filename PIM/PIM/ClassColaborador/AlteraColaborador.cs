using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public class AlteraColaborador : ConectaDb
    {

        public bool AlterColaborador(ClassColaborador.Colaborador c)
        {
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "UPDATE colaborador SET nome=@nome, data_nascimento=@data_nascimento, sexo=@sexo, ddd=@ddd, telefone=@telefone, celular=@celular, email=@email, logradouro=@logradouro, numero=@numero, bairro=@bairro, cep=@cep, complemento=@complemento, cidade=@cidade, estado=@estado, pais=@pais, cpf=@cpf, rg=@rg, ctps=@ctps, pis=@pis, salario=@salario  WHERE id_colaborador=@idColaborador;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("idColaborador", c.idColaborador));
                cmd.Parameters.Add(new MySqlParameter("nome", c.nome));
                cmd.Parameters.Add(new MySqlParameter("data_nascimento", c.dataNascimento));
                cmd.Parameters.Add(new MySqlParameter("sexo", c.sexo));
                cmd.Parameters.Add(new MySqlParameter("email", c.email));
                cmd.Parameters.Add(new MySqlParameter("logradouro", c.logradouro));
                cmd.Parameters.Add(new MySqlParameter("numero", c.num));
                cmd.Parameters.Add(new MySqlParameter("bairro", c.bairro));
                cmd.Parameters.Add(new MySqlParameter("cep", c.cep));
                cmd.Parameters.Add(new MySqlParameter("complemento", c.complemento));
                cmd.Parameters.Add(new MySqlParameter("cidade", c.cidade));
                cmd.Parameters.Add(new MySqlParameter("estado", c.estado));
                cmd.Parameters.Add(new MySqlParameter("pais", c.pais));
                cmd.Parameters.Add(new MySqlParameter("cpf", c.cpf));
                cmd.Parameters.Add(new MySqlParameter("rg", c.rg));
                cmd.Parameters.Add(new MySqlParameter("ddd", c.ddd));
                cmd.Parameters.Add(new MySqlParameter("telefone", c.tel));
                cmd.Parameters.Add(new MySqlParameter("celular", c.cel));
                cmd.Parameters.Add(new MySqlParameter("ctps", c.ctps));
                cmd.Parameters.Add(new MySqlParameter("pis", c.pis));
                cmd.Parameters.Add(new MySqlParameter("salario", c.salario));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.ToString());
                return false;
            }

        }

    }
}
