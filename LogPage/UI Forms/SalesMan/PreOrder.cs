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
        {   string productName = nameTxt.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            { MessageBox.Show("Enter product name.");  return;}

            if (!int.TryParse(quantityTxt.Text.Trim(), out int quantity) || quantity <= 0)
            {  MessageBox.Show("Enter a valid quantity (positive integer).");
                return;
            }

            string mobile = mobileTxt.Text.Trim();
            if (string.IsNullOrEmpty(mobile))  { MessageBox.Show("Enter customer mobile."); return; }            
            if (mobile.Length < 11 || !mobile.All(char.IsDigit)){ MessageBox.Show("Mobile number must be at least 11 digits and numeric.");return;}

            DateTime preferredDate = preferedDateTxt.Value.Date;
            if (preferredDate < DateTime.Today)
            {  MessageBox.Show("Preferred date cannot be before today."); return; }
            string sql = "INSERT INTO PreOrder (ProductName, Quantity, CustomerMobile, PreferredDate) " +
                         "VALUES ('" + productName + "', " + quantity + ", '" + mobile + "', '" + preferredDate.ToString("yyyy-MM-dd") + "')";

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pre-order submitted.");
            }
            catch (SqlException ex) {MessageBox.Show("DB error: " + ex.Message);  }
            catch (Exception ex)  {MessageBox.Show("Error: " + ex.Message);   }
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
        private void preOrderBtn_Click(object sender, EventArgs e){ InsertPreOrder();}
        private void homeBtn_Click(object sender, EventArgs e)
        {   Salesman S = new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
            this.Hide();
        }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {    Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }
        private void pQueryBtn_Click(object sender, EventArgs e)
        {   ProductQuery PQ = new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
            this.Hide();
        }
        private void cManagementBtn_Click(object sender, EventArgs e)
        {   CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }
        private void viewPreOrderbtn_Click(object sender, EventArgs e) { LoadPreOrders(); }

        private void clearBtn_Click(object sender, EventArgs e)
        {   nameTxt.Text = "";   mobileTxt.Text = "";  quantityTxt.Text = "";   preferedDateTxt.Text = "";   }
        private void preferedDateTxt_ValueChanged(object sender, EventArgs e)  {  }
    }
}
