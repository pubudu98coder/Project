using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3LVIJ795\MSSQLSERVER02;Initial Catalog=store;Integrated Security=True");

        private void populate1()
        {
            con.Open();

            string query = "SELECT item_name,unit_price,quantity  FROM item where item_code like 'ST%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagridview.DataSource = ds.Tables[0];
            con.Close();

        }
        private void populate2()
        {
            con.Open();

            string query = "SELECT item_name,unit_price,quantity  FROM item where item_code like 'T%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagridview.DataSource = ds.Tables[0];
            con.Close();

        }
        private void populate3()
        {
            con.Open();

            string query = "SELECT item_name,unit_price,quantity  FROM item where item_code like 'J%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagridview.DataSource = ds.Tables[0];
            con.Close();

        }

        private void populate4()
        {
            con.Open();

            string query = "SELECT item_name,unit_price,quantity  FROM item where item_code like 'SP%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagridview.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btnStationery_Click(object sender, EventArgs e)
        {
            populate1();
            category.Text = "Stationary";
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            populate2();
            category.Text = "Toys";
        }

        private void btnJewel_Click(object sender, EventArgs e)
        {
            populate3();
            category.Text = "jewellery";
        }

        private void btnSpice_Click(object sender, EventArgs e)
        {
            populate4();
            category.Text = "Spice";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new InventoryManagement().Show();
        }
    }
}
