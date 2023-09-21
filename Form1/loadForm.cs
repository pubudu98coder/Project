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
    public partial class loadForm : Form
    {
        public loadForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) {
                progressBar1.Value += 1;
                label3.Text = progressBar1.Value.ToString() + "%";

            }

            else
            {
                timer1.Stop();
                //MessageBox.Show("hbj");
                this.Hide();
                Login login = new Login(this);
                login.Show();
                //this.Close();
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
