using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlConnection con;

        public void CreateDatabaseConnection() {
            connectionString = "Data Source=LAPTOP-CU5ENQDH\\MSSQLSERVER02;Initial Catalog=myData;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            MessageBox.Show("Successfully connected");

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDatabaseConnection();
            string itemID = textBox2.Text;
            MessageBox.Show(itemID);
            try
            {
         
                MessageBox.Show("Successfully connected");


                string deleteQuery = "DELETE FROM item WHERE item_code = @ItemID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    // Add a parameter to the command.
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    // Execute the DELETE query.
                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Item with specified ItemID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    

        
    }
}
