using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryItems_update
{
    public partial class Update : Form
    {

        SqlConnection conn;
        int index;
        public Update()
        {
            InitializeComponent();
            conn = dbconnection.Connect();
            ShowItems();
        }

        public void ShowItems()
        {
            string sql = "select * from item";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Items_DataGridView1.DataSource = dt;
        }






        /*private void Items_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Items_DataGridView1.Rows[index];
            ItemCode_textBox1.Text = row.Cells[0].Value.ToString();
            ItemName_textBox2.Text = row.Cells[1].Value.ToString();
            Price_textBox3.Text = row.Cells[2].Value.ToString();
            Stock_textBox4.Text = row.Cells[3].Value.ToString();

        }
        */
        /*
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the DataGridView
            if (index >= 0)
            {
                try
                {
                    // Get the values from the text boxes
                    string item_code = ItemCode_textBox1.Text;
                    string item_name = ItemName_textBox2.Text;
                    decimal unit_price = decimal.Parse(Price_textBox3.Text);
                    decimal quantity = decimal.Parse(Stock_textBox4.Text);

                    // Create an update SQL query
                    string updateQuery = "UPDATE item SET item_name = @ItemName, unit_price = @Price, quantity = @Stock WHERE item_code = @ItemCode";

                    using (SqlConnection updateConn = dbconnection.Connect())
                    {
                        updateConn.Open();
                        SqlCommand updateCmd = new SqlCommand(updateQuery, updateConn);

                        // Set parameters for the update query
                        updateCmd.Parameters.AddWithValue("@ItemCode", item_code);
                        updateCmd.Parameters.AddWithValue("@ItemName", item_name);
                        updateCmd.Parameters.AddWithValue("@Price", unit_price);
                        updateCmd.Parameters.AddWithValue("@Stock", quantity);

                        // Execute the update query
                        updateCmd.ExecuteNonQuery();

                        // Refresh the DataGridView to reflect the updated data
                        ShowItems();

                        // Clear the text boxes
                        btnClear_Click(sender, e);

                        MessageBox.Show("Item updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the DataGridView to update.");
            }
        }
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            ItemCode_textBox1.Clear();
            ItemName_textBox2.Clear();
            Price_textBox3.Clear();
            Stock_textBox4.Clear();
        }

        private void Items_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Items_DataGridView1.Rows[index];
            ItemCode_textBox1.Text = row.Cells[0].Value.ToString();
            ItemName_textBox2.Text = row.Cells[1].Value.ToString();
            Price_textBox3.Text = row.Cells[2].Value.ToString();
            Stock_textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the DataGridView
            if (index >= 0)
            {
                try
                {
                    // Get the values from the text boxes
                    string item_code = ItemCode_textBox1.Text;
                    string item_name = ItemName_textBox2.Text;
                    decimal unit_price = decimal.Parse(Price_textBox3.Text);
                    decimal quantity = decimal.Parse(Stock_textBox4.Text);

                    // Create an update SQL query
                    string updateQuery = "UPDATE item SET item_name = @ItemName, unit_price = @Price, quantity = @Stock WHERE item_code = @ItemCode";

                    using (SqlConnection updateConn = dbconnection.Connect())
                    {
                        updateConn.Open();
                        SqlCommand updateCmd = new SqlCommand(updateQuery, updateConn);

                        // Set parameters for the update query
                        updateCmd.Parameters.AddWithValue("@ItemCode", item_code);
                        updateCmd.Parameters.AddWithValue("@ItemName", item_name);
                        updateCmd.Parameters.AddWithValue("@Price", unit_price);
                        updateCmd.Parameters.AddWithValue("@Stock", quantity);

                        // Execute the update query
                        updateCmd.ExecuteNonQuery();

                        // Refresh the DataGridView to reflect the updated data
                        ShowItems();

                        // Clear the text boxes
                        btnClear_Click(sender, e);

                        MessageBox.Show("Item updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the DataGridView to update.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new InventoryManagement().Show();
        }

        private void search_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
