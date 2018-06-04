using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ClassVenda
{
    public class InsereVenda : ConectaDb
    {
        long id = -1;
        public long SalvaVenda(Venda v)
        {
            try
            {
                conn = new MySqlConnection(str);
                String query = "INSERT INTO venda (id_vendedor, id_comprador, data, comp)VALUES(@id_vendedor, @id_comprador, @data, @comp);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_vendedor", v.id_vendedor));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_comprador", v.id_comprador));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("data", v.data));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("comp", v.comp));

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                id = cmd.LastInsertedId;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.ToString());

            }
            return id;

        }

    }
}
