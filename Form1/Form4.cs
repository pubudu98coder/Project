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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string comboBox1txt = null;
        public bool over = true;
        static int rowIndex = 0;
        static int i = 0;
        static Item[] itemList = new Item[30];
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
            var dataBase = new Database();
            if (dataBase.connect_database())
            {
                //
                String query = "SELECT* FROM item WHERE item_name LIKE '" + comboBox1txt + "';";
                SqlCommand command = new SqlCommand(query);
                command.Connection = dataBase.conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                dataBase.close_connection();
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                comboBox1txt = textBox1.Text + "%";
                loadData();
            }
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Add(1);
                if (e.RowIndex != -1)
                {
                    row = dataGridView1.Rows[e.RowIndex];
                    itemList[i] = new Item();
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
                    sub= itemList[j].quantity * itemList[j].unitPrice;
                    row1.Cells[4].Value=sub;
                    totalP += sub;
                    txtTotal.Text = totalP.ToString();
                 }
                rowIndex++;
                i++;             
        }
    }
    public class Item
    {
        public string itemCode = null;
        public string itemName = null;
        public float unitPrice = 0;
        public float quantity = 0;
    }
}

