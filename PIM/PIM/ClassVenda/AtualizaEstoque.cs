using MySql.Data.MySqlClient;
using PIM.ClassCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class AtualizaEstoque : ConectaDb
    {
        InsertCompra cp = new InsertCompra();
        checkItemCompra cit = new checkItemCompra();
        public void Atualiza(List<ClassProduto.Produto> p)
        {
            foreach (var pro in p)
            {
                try
                {
                    conn = new MySqlConnection(str);
                    String query = "UPDATE produto SET quantidade=@qtd WHERE id_produto = @id_produto; ";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_produto", pro.idPro));
                    pro.qtd = pro.qtd - 1;
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("qtd", pro.qtd));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    if (pro.qtd <= pro.qtdMin)
                    {
                        if(!cit.checkCompra(pro.idPro))
                        {
                            cp.SalvaCompra(pro);
                        }                        
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }

            }
        }
    }
}
