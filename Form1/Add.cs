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
using Form1;

namespace groceryManagementSystem
{
    public partial class Add : Form
    {
        
        public Add()
        {
            InitializeComponent();
            SqlConnection con;
            string ConnString = @"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True;";
            con = new SqlConnection(ConnString);
            con.Open(); ;

            SqlCommand cmd1 = new SqlCommand("select * from item", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_itemcode.Text = string.Empty;
            txt_itemname.Text = string.Empty;
            txt_unitprice.Text = string.Empty;
            txt_quantity.Text = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string ConnString = @"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True;";
            con = new SqlConnection(ConnString);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO item (item_code, item_name, unit_price, quantity) VALUES (@item_code, @item_name, @unit_price, @quantity)", con);
            cmd.Parameters.AddWithValue("@item_code", txt_itemcode.Text);
            cmd.Parameters.AddWithValue("@item_name", txt_itemname.Text);
            cmd.Parameters.AddWithValue("@unit_price", txt_unitprice.Text);
            cmd.Parameters.AddWithValue("@quantity", txt_quantity.Text);

            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("select * from item", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            MessageBox.Show("Successfully saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new InventoryManagement().Show();
        }
    }
}
