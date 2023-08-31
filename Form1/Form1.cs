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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            String username = usernametxt.Text;
            String password = passwordtxt.Text;
            if(!(Convert.ToBoolean(string.Compare(username,"pubudu"))&& Convert.ToBoolean(string.Compare(password, "pubudu123")))) {
                this.Hide();
                Form3 optionForm = new Form3();
                optionForm.Show();
            }
            else
                MessageBox.Show("Login Failed!");
        }


        private void btnSign_Click(object sender, EventArgs e)
        {
           Form2 signForm = new Form2(this);
           

            signForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            usernametxt.Text = "";
            passwordtxt.Text = "";
        }
    }
}
