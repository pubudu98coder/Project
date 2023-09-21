using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;

namespace Form1
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        string search = null;
        public bool over = true;
        static int rowIndex = 0;
        static int i = 0;

        public static SaleItem[] itemList = new SaleItem[30];
        static DataGridViewRow row1;
        static DataGridViewRow row;
        static float totalP = 0f;
        static float sub = 0;

        //item array

        private void Form4_Load(object sender, EventArgs e)
        {
            //string search
        }
        public void loadData()
        {

            DBConn dbc = DBConn.getDBConn();
            SqlConnection conn = dbc.getConnection();

            String query = "SELECT item_code,item_name,unit_price FROM item WHERE item_name LIKE '" + search + "';";

            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            dataGridView1.DataSource = bindingSource;
            conn.Close();
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                search = textBox1.Text + "%";
                loadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Add(1);
            if (e.RowIndex != -1)
            {
                row = dataGridView1.Rows[e.RowIndex];
                itemList[i] = new SaleItem();
                itemList[i].itemCode = row.Cells[0].Value.ToString();
                itemList[i].itemName = row.Cells[1].Value.ToString();
                string priceString = row.Cells[2].Value.ToString();
                itemList[i].unitPrice = float.Parse(priceString);
                itemList[i].quantity = float.Parse(txtQuantity.Text);
            }

            totalP = 0;
            for (int j = 0; j <= rowIndex; j++)
            {
                row1 = dataGridView2.Rows[j];
                row1.Cells[0].Value = itemList[j].itemCode;
                row1.Cells[1].Value = itemList[j].itemName;
                row1.Cells[2].Value = itemList[j].unitPrice;
                row1.Cells[3].Value = itemList[j].quantity;
                sub = itemList[j].quantity * itemList[j].unitPrice;
                row1.Cells[4].Value = sub;
                totalP += sub;
                txtTotal.Text = totalP.ToString();
            }
            rowIndex++;
            i++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
        }

           

        private void btnEndSale_Click(object sender, EventArgs e)
        {
            string item_Name;
            float qty;
            var dataBase = new Database();
            dataBase.connect_database();
            for (int k = 0; k < i; k++)
            {
                qty = itemList[k].quantity;
                item_Name = itemList[k].itemName;


                string sql = "UPDATE item SET quantity = quantity -" + qty + " WHERE item_name='" + item_Name + "'";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = dataBase.conn;
                cmd.ExecuteNonQuery();
            }
        }
    }
}

