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
    public partial class Cashier_Home : Form
    {
       


     public Cashier_Home()
    {
        InitializeComponent();
    }
    public void loadform(object Form)
    {
        if (this.mainPnl.Controls.Count > 0)
        
            this.mainPnl.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPnl.Controls.Add(f);
            this.mainPnl.Tag = f;
            f.Show();
        

}

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Cashier_Home h = new Cashier_Home();  
            h.Show();
            this.Hide();
        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            loadform(new POS());
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            loadform(new Return());
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            loadform(new Stock());
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            loadform(new Report());
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            loadform(new Profile());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.Show();

           
            this.Close();  
        }
    }
}
