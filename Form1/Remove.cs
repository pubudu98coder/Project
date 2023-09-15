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
using Org.BouncyCastle.Asn1.X509;

namespace Form1
{
    public partial class Remove : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True");

        public Remove()
        {
            InitializeComponent();
        }


        public void populateGrid(string sorting = "")
        {

            con.Open();
            string query = "select *from item" + sorting;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        public void TextBoxFilter()
        {
            con.Open();
            string query = "select *from item where item_code LIKE '%" + textBox1.Text + "%' or item_name LIKE '%" + textBox1.Text + "%' or unit_price LIKE '" + textBox1.Text + "%' or quantity LIKE '" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }


        private void Form8_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxFilter();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.SelectedRows[0].Cells.Count >= 3)
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            populateGrid();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string itemID = textBox2.Text;

            if (itemID != null)
            {
                try
                {
                    string deleteQuery = "DELETE FROM item WHERE item_code = @ItemID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        // Add a parameter to the command.
                        cmd.Parameters.AddWithValue("@ItemID", itemID);

                        if (MessageBox.Show("Do you Want To Remove This", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
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
                        else
                        {
                            populateGrid();
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox4.Text = null;
                            textBox5.Text = null;

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
            else
            {
                MessageBox.Show("There is no selected Item to delete.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = comboBox1.SelectedItem.ToString();
            string orderBy;
            if (selectedValue == "Item Name")
            {
                orderBy = " ORDER BY item_name ASC";
            }
            else if (selectedValue == "Item Code")
            {
                MessageBox.Show("Unit price");
                orderBy = " ORDER BY item_code ASC";

            }
            else if (selectedValue == "Unit Price")
            {

                orderBy = " ORDER BY unit_price ASC";
            }

            else
            {
                orderBy = " ORDER BY quantity ASC";
            }

            populateGrid(orderBy);





        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
