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
    public partial class Salesman_Home : Form
    {   
     public Salesman_Home()
    { InitializeComponent(); }  

        private void profilebtn_Click(object sender, EventArgs e)
        {
            Salesman_Profile p = new Salesman_Profile();            
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.Show();           
            this.Close();  
        }

        private void Cashier_Home_Load(object sender, EventArgs e) { }

       

        private void customerBtn_Click(object sender, EventArgs e)
        {   Add_Customer p = new Add_Customer();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {   Feedback p = new Feedback();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {   Discount p = new Discount();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {   Stock p = new Stock();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }
    }
}
