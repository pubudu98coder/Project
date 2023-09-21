using GroceryItems_update;
using groceryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
            Remove remove=new Remove();
            remove.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Close();
            View view = new View();
            view.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
            Update update = new Update();
            update.Show();
        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            Add add = new Add();
            add.Show();
        }
    }
}
