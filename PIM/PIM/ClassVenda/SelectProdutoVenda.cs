using MySql.Data.MySqlClient;
using PIM.ClassProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class SelectProdutoVenda : ConectaDb
    {
        public Produto BuscarProduto(int id)
        {
            int total = 0;
            Produto p = new Produto();
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
                    p.idPro = Convert.ToInt32(leitor["id_produto"]);
                    p.marca = leitor["marca"].ToString();
                    p.nome = leitor["nome_produto"].ToString();
                    p.qtd = Convert.ToInt32(leitor["quantidade"]);
                    p.valor = Convert.ToDouble(leitor["valor"]);
                    p.desconto = Convert.ToDouble(leitor["desconto"]);
                    p.codigo = Convert.ToInt32(leitor["codigo_barra"]);
                    p.foto = leitor["foto"].ToString();
                    p.cor = leitor["cor"].ToString();
                    p.tamanho = leitor["tamanho"].ToString();
                    p.qtdMin = Convert.ToInt32(leitor["quantidade_minima"]);
                    p.dataCadastro = Convert.ToDateTime(leitor["data_cadastro"]);
                    total = Convert.ToInt32(leitor["quantidade"]);
                }
                conn.Close();
                if (total <= 0)
                {
                    MessageBox.Show("Falta o Item no estoque. A entrega será feita assim que o item for recolocado no estoque.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());

            }
            return p;
        }
    }
}
