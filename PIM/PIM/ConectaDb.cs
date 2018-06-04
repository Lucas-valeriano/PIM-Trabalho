using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    public class ConectaDb
    {
        public String str = @"server = localhost; user id = root; password =lucas@2018; persistsecurityinfo = True; port = 3306; database = pim; SslMode = none";
        public MySqlConnection conn = null;
        public MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }
    }
    
}
