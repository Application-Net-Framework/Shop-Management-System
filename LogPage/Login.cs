using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogPage
{
    public partial class LogPage : Form
    {   string userName = "arif.cashier";   
        string pass = "12345";
        public LogPage()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string uname = uNameTxt.Text.Trim();
            string Pass = passTxt.Text.Trim();

            //if (Pass == pass && uname == userName && uname.EndsWith(".admin"))
            if (Pass == pass && uname.EndsWith(".admin"))
            {   MessageBox.Show("Login Successful as Admin!");
                Admin_Home admin = new Admin_Home();
                admin.Show();
                this.Hide();
            }
            //if (Pass == pass && uname == userName && uname.EndsWith(".manager"))
            if (Pass == pass &&  uname.EndsWith(".manager"))
            {   MessageBox.Show("Login Successful as Manager!");
                Manager_Home manager = new Manager_Home();
                manager.Show();
                this.Hide();
            }
            //if (Pass == pass && uname == userName && uname.EndsWith(".cashier"))
            if (Pass == pass  && uname.EndsWith(".cashier"))
            {
                MessageBox.Show("Login Successful as Cashier!");
                Cashier_Home cashier = new Cashier_Home();
                cashier.Show();
                this.Hide();            }
            //if (Pass == pass && uname == userName && uname.EndsWith(".salesman"))
            if (Pass == pass && uname.EndsWith(".salesman"))
            {
                MessageBox.Show("Login Successful as Salesman!");
                SalesMan_Home sales = new SalesMan_Home();
                sales.Show();
                this.Hide();            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            } }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register homeForm = new Register();
            homeForm.Show();
            this.Hide();
        }

        private void fPassBtn_Click(object sender, EventArgs e)
        {

            ForgetPass homeForm = new ForgetPass();
            homeForm.Show();
            this.Hide();
        }

        private void uNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void uNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passBtn_Click(object sender, EventArgs e)
        {

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void messageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
