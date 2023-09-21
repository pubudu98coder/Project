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
    public partial class Sign : Form
    {
        Form f;
        public Sign( Form form1 )
        {
            f = form1;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            //Form1 loginForm = new Form1();
            //loginForm.Show();
            f.Show();
        }
    }
}
