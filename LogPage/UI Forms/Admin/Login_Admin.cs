using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration_Admin A= new Registration_Admin();
            A.Show();
            this.Hide();
        }

        private void Login_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
