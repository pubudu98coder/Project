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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing billingForm = new Billing();
            billingForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagment=new InventoryManagement();
            this.Close();
            inventoryManagment.Show();
        }
    }
}
