using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassProduto
{
    public class InsertProduto : ConectaDb
    {
        public bool SalvaProduto(Produto p)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "INSERT INTO produto (marca, nome_produto, quantidade, valor, desconto, codigo_barra, foto, cor, tamanho, data_cadastro, quantidade_minima)VALUES(@marca, @nome_produto, @quantidade, @valor, @desconto, @codigo_barra, @foto, @cor, @tamanho, @data_cadastro, @quantidade_minima);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("marca", p.marca));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_produto", p.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade", p.qtd));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("valor", p.valor));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("desconto", p.desconto));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("codigo_barra", p.codigo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("foto", p.foto));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cor", p.cor));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("tamanho", p.tamanho));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data_cadastro", p.dataCadastro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("quantidade_minima", p.qtdMin));
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
