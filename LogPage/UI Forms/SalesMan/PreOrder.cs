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
    public partial class PreOrder : Form
    {
        public PreOrder() { InitializeComponent(); }
        String connectionString = GlobalConfig.ConnectionString;
        private void InsertPreOrder()
        {
            
            if (!int.TryParse(pIdTxt.Text.Trim(), out int productId) || productId <= 0)
            {   MessageBox.Show("Enter a valid Product ID (positive integer)."); return; }

            string productName = pNameTxt.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            { MessageBox.Show("Enter product name."); return;}

            if (!int.TryParse(pQuantityTxt.Text.Trim(), out int quantity) || quantity <= 0)
            { MessageBox.Show("Enter a valid quantity (positive integer)."); return; }

            if (!int.TryParse(cIdTxt.Text.Trim(), out int customerId) || customerId <= 0)
            { MessageBox.Show("Enter a valid Customer ID (positive integer).");return;}

            string customerName = cNameTxt.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            { MessageBox.Show("Enter customer name.");return;}
            
            string mobile = cMobileTxt.Text.Trim();
            if (string.IsNullOrEmpty(mobile))  {MessageBox.Show("Enter customer mobile.");  return;  }
            if (mobile.Length < 11 || !mobile.All(char.IsDigit))
            {  MessageBox.Show("Mobile number must be at least 11 digits and numeric."); return;}
            
            DateTime preferredDate = preferedDateTxt.Value.Date;
            if (preferredDate < DateTime.Today)
            {MessageBox.Show("Preferred date cannot be before today.");return;}
            string sql = "INSERT INTO PreOrder (PreOrderProductID, ProductName, Quantity, CustomerID, CustomerName, CustomerMobile, PreferredDate) " +
                         "VALUES (" + productId + ", '" + productName + "', " + quantity + ", " + customerId + ", '" + customerName + "', '" + mobile + "', '" + preferredDate.ToString("yyyy-MM-dd") + "')";

            try
            {
                 SqlConnection con = new SqlConnection(connectionString);
                 SqlCommand cmd = new SqlCommand(sql, con);
                 con.Open();
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Pre-order submitted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadPreOrders()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT PreOrderID, ProductName, Quantity, CustomerMobile, DateRequested, PreferredDate FROM PreOrder";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading pre-orders: " + ex.Message);
            }
        }
        private void preOrderBtn_Click(object sender, EventArgs e) 
        { InsertPreOrder(); }


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
        private void pQueryBtn_Click(object sender, EventArgs e)
        {
            ProductQuery PQ = new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
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
        private void viewPreOrderbtn_Click(object sender, EventArgs e) { LoadPreOrders(); }

        private void clearBtn_Click(object sender, EventArgs e)
        { pIdTxt.Text = ""; pQuantityTxt.Text = ""; pSearchTxt.Text = ""; preferedDateTxt.Text = ""; }
        private void preferedDateTxt_ValueChanged(object sender, EventArgs e) { }

        private void sProductBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PreOrderProductID, ProductName, Category, Description, UnitPriceDescription " +
                               "FROM PreOrderProduct " +
                               "WHERE ProductName LIKE '%" + pSearchTxt.Text + "%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }           
            productGrid.DataSource = dt;

        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PreOrderProductID, ProductName, Category, Description, UnitPrice " +
                               "FROM PreOrderProduct ORDER BY ProductName ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            productGrid.DataSource = dt;
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, Name, Phone,  MembershipType " +
                               "FROM Customer " +
                               "WHERE Phone LIKE '%" + customerSearchTxt.Text + "%' " +
                               "   OR Name LIKE '%" + customerSearchTxt.Text + "%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
             customerGrid.DataSource = dt;
        }
        private void customerListBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, Name, Phone,  MembershipType " +
                               "FROM Customer " +
                               "ORDER BY Name ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            customerGrid.DataSource = dt;
        }
        private void productGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pIdTxt.Text = productGrid.Rows[e.RowIndex].Cells["PreOrderProductID"].Value.ToString();
            pNameTxt.Text = productGrid.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            
        }
        private void customerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cIdTxt.Text = customerGrid.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            cNameTxt.Text = customerGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            cMobileTxt.Text = customerGrid.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
        }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }

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

















