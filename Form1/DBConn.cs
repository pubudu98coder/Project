using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    internal class DBConn
    {
        private static DBConn _dbConn = null;
        private static string connString = @"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True";


        public static DBConn getDBConn()
        {
            if (_dbConn == null)
            {
                _dbConn = new DBConn();
            }
            return _dbConn;
        }
        private DBConn()
        {

        }

        public SqlConnection getConnection()
        {
            SqlConnection _conn = new SqlConnection(connString);
            return _conn;
        }



    }
}
