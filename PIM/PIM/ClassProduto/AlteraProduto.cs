using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassProduto
{
    public class AlteraProduto : ConectaDb
    {
        public bool AtualizaProduto(Produto p)
        {
            try
            {

                conn = new MySqlConnection(str);
                String query = "UPDATE produto SET marca=@marca, nome_produto=@nome_produto, quantidade=@quantidade, valor=@valor, desconto=@desconto, codigo_barra=@codigo_barra, foto=@foto, cor=@cor, tamanho=@tamanho, quantidade_minima=@quantidade_minima WHERE id_produto=@id;";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", p.idPro));
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
