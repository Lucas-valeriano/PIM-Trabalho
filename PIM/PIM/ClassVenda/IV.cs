using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.ClassVenda
{
    public class IV : ConectaDb
    {
        List<ClassProduto.Produto> prod = new List<ClassProduto.Produto>();
        ClassProduto.SelecionaProd edp = new ClassProduto.SelecionaProd();
        public List<ClassProduto.Produto> SelectP(int id)
        {
            ClassProduto.Produto p = new ClassProduto.Produto();
            try
            {
                MySqlConnection conn = new ConectaDb().getConnection();
                String query = "SELECT * FROM item WHERE id_venda=@id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    p = edp.BuscarEditarProduto(Convert.ToInt32(leitor["id_produto"]));
                    prod.Add(p);
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
