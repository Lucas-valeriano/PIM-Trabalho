using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassProduto
{
    public class SelectEditPro : ConectaDb
    {
        public List<Produto> BuscarEditarProduto(int id)
        {
            List<Produto> pro = new List<Produto>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM produto WHERE id_produto=@id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    Produto p = new Produto()
                    {
                        idPro = Convert.ToInt32(leitor["id_produto"]),
                        marca = leitor["marca"].ToString(),
                        nome = leitor["nome_produto"].ToString(),
                        qtd = Convert.ToInt32(leitor["quantidade"]),
                        valor = Convert.ToDouble(leitor["valor"]),
                        desconto = Convert.ToDouble(leitor["desconto"]),
                        codigo = Convert.ToInt32(leitor["codigo_barra"]),
                        foto = leitor["foto"].ToString(),
                        cor = leitor["cor"].ToString(),
                        tamanho = leitor["tamanho"].ToString(),
                        qtdMin = Convert.ToInt32(leitor["quantidade_minima"]),
                        dataCadastro = Convert.ToDateTime(leitor["data_cadastro"])
                    };
                    pro.Add(p);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());

            }
            return pro;
        }
    }
}
