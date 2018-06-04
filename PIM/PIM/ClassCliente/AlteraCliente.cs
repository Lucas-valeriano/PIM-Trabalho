using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PIM.ClassCliente
{
    public class AlteraCliente: ConectaDb
    {
        public bool AlterCliente(Cliente c)
        {
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "UPDATE cliente SET nome=@nome, data_nascimento=@data_nascimento, sexo=@sexo, email=@email, logradouro=@logradouro, numero=@numero, bairro=@bairro, cep=@cep, complemento=@complemento, cidade=@cidade, estado=@estado, pais=@pais, cpf=@cpf, rg=@rg, ddd=@ddd, telefone=@telefone, celular=@celular WHERE id_cliente=@idCliente;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("idCliente", c.idCliente));
                cmd.Parameters.Add(new MySqlParameter("nome", c.nome));
                cmd.Parameters.Add(new MySqlParameter("data_nascimento", c.data_nascimento));
                cmd.Parameters.Add(new MySqlParameter("sexo", c.sexo));
                cmd.Parameters.Add(new MySqlParameter("email", c.email));
                cmd.Parameters.Add(new MySqlParameter("logradouro", c.logradouro));
                cmd.Parameters.Add(new MySqlParameter("numero", c.numero));
                cmd.Parameters.Add(new MySqlParameter("bairro", c.bairro));
                cmd.Parameters.Add(new MySqlParameter("cep", c.cep));
                cmd.Parameters.Add(new MySqlParameter("complemento", c.complemento));
                cmd.Parameters.Add(new MySqlParameter("cidade", c.cidade));
                cmd.Parameters.Add(new MySqlParameter("estado", c.estado));
                cmd.Parameters.Add(new MySqlParameter("pais", c.pais));
                cmd.Parameters.Add(new MySqlParameter("cpf", c.cpf));
                cmd.Parameters.Add(new MySqlParameter("rg", c.rg));
                cmd.Parameters.Add(new MySqlParameter("ddd", c.ddd));
                cmd.Parameters.Add(new MySqlParameter("telefone", c.telefone));
                cmd.Parameters.Add(new MySqlParameter("celular", c.celular));
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
