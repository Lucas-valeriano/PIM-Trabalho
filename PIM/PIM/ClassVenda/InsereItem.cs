using MySql.Data.MySqlClient;
using PIM.ClassCompra;
using PIM.ClassProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class InsereItem : ConectaDb
    {
        double saldo = 0;
        AtualizaEstoque at = new AtualizaEstoque();
        LancamentoContabilVenda lc = new LancamentoContabilVenda();
        VendaSemProduto vs = new VendaSemProduto();
        public void SalvaItem(List<Produto> p, int id, int idU)
        {
            foreach (var pro in p)
            {
                try
                {
                    conn = new MySqlConnection(str);
                    String query = "INSERT INTO item (id_venda, id_produto)VALUES(@id_venda, @id_produto);";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_produto", pro.idPro));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_venda", id));
                    saldo = saldo + pro.valor;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if(pro.qtd <= 0)
                    {
                        vs.SalvaVenda100Produto(id , pro.idPro);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }
                at.Atualiza(p);
            }
            lc.LCVenda(id, saldo);
        }
    }
}
