using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassProduto
{
    class ProdutoDashboardCR : ConectaDb
    {
        public Double ar { get; set; }
        Double r;
        public List<Produto> BuscarProdutoCCR()
        {
            List<Produto> prod = new List<Produto>();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM produto WHERE id_produto in (SELECT id_produto FROM item);";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
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
                    prod.Add(p);
                    r = Convert.ToDouble(leitor["valor"]);
                    ar = ar + r;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            return prod;
        }
    }
}
