using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GroceryItems_update
{
    internal class dbconnection
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn;
            try
            {
                string ConnString = @"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True;";
                conn = new SqlConnection(ConnString);
                conn.Open();
                // MessageBox.Show("Connectd Successfully");
                conn.Close();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }
        }


    }
}
