using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select ProductID, ProductName, CateogoryName from Product;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            //DataTable dt2 = ds.Tables[1];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

            pnlHome.Visible = true;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = true;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = true;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = true;
            pnlProfile.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = true;
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(25, 112, 255);
            btnProduct.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(255, 255, 255);
            btnProduct.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(255, 255, 255);
            btnHome.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(25, 112, 255);
            btnHome.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(255, 255, 255);
            btnOrder.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(25, 112, 255);
            btnOrder.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnFeedback_MouseLeave(object sender, EventArgs e)
        {
            btnFeedback.BackColor = Color.FromArgb(255, 255, 255);
            btnFeedback.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnFeedback_MouseMove(object sender, MouseEventArgs e)
        {
            btnFeedback.BackColor = Color.FromArgb(25, 112, 255);
            btnFeedback.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(255, 255, 255);
            btnProfile.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnProfile_MouseMove(object sender, MouseEventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(25, 112, 255);
            btnProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void SalesMan_Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSMSdbDataSet_CashierProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.gSMSdbDataSet_CashierProduct.Product);

        }
    }
}
