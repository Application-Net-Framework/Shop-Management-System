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
using App.Configuration;

namespace App.UI_Forms.SalesMan
{
    public partial class ProductQuery : Form
    {
        String connectionString = GlobalConfig.ConnectionString;
        public ProductQuery()
        { InitializeComponent(); }

        private void SearchByName(string productName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "SELECT ProductID, ProductName, CategoryName, Price, Stock, ExpiryDate FROM Product " +
                               "WHERE ProductName LIKE '%" + productName + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void LoadAllProducts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "SELECT ProductID, ProductName, CategoryName, Price, Stock, ExpiryDate, Description FROM Product";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ProductQuery_Load(object sender, EventArgs e) { }
        private void pQueryBtn_Click(object sender, EventArgs e) { }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman S = new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
            this.Hide();
        }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }
        private void cManagementBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }
        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            PreOrder PO = new PreOrder();
            PO.StartPosition = FormStartPosition.Manual;
            PO.Location = this.Location;
            PO.Size = this.Size;
            PO.Show();
            this.Hide();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        { SearchByName(nameTxt.Text); }
        private void stockBtn_Click(object sender, EventArgs e)
        { LoadAllProducts(); }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Size = this.Size;
            login.Show();
            this.Close();
        }
    }
}
