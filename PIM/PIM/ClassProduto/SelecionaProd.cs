using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassProduto
{
    public class SelecionaProd
    {
        public Produto BuscarEditarProduto(int id)
        {
            Produto pro = new Produto();
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

                    pro.idPro = Convert.ToInt32(leitor["id_produto"]);
                    pro.marca = leitor["marca"].ToString();
                    pro.nome = leitor["nome_produto"].ToString();
                    pro.qtd = Convert.ToInt32(leitor["quantidade"]);
                    pro.valor = Convert.ToDouble(leitor["valor"]);
                    pro.desconto = Convert.ToDouble(leitor["desconto"]);
                    pro.codigo = Convert.ToInt32(leitor["codigo_barra"]);
                    pro.foto = leitor["foto"].ToString();
                    pro.cor = leitor["cor"].ToString();
                    pro.tamanho = leitor["tamanho"].ToString();
                    pro.qtdMin = Convert.ToInt32(leitor["quantidade_minima"]);
                    pro.dataCadastro = Convert.ToDateTime(leitor["data_cadastro"]);

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
