using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Form1
{
    internal class Database
    {
        //using sql server
        public static readonly string conn_string = @"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=myData;Integrated Security=True";


        public SqlConnection conn = new SqlConnection(conn_string);

        public bool connect_database()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool close_connection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
