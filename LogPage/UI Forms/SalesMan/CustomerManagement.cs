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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement() { InitializeComponent(); }
        string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        private void AddCustomer()
        {   string name = nameTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string status = statusTxt.Text.Trim();
          
            if (string.IsNullOrEmpty(name)) {  MessageBox.Show("Name cannot be empty."); return; }           
            if (string.IsNullOrEmpty(status)) {MessageBox.Show("Membership Type cannot be empty.");return; }
            if (string.IsNullOrEmpty(mobile) || mobile.Length < 11 || !mobile.All(char.IsDigit))
            { MessageBox.Show("Mobile number must be at least 11 digits and contain only numbers."); return; }
            if (!string.IsNullOrEmpty(email) && !email.Contains("@"))
            { MessageBox.Show("Invalid email address. Email must contain '@'."); return; }

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();                
                string checkMobileQuery = $"SELECT COUNT(*) FROM Customer WHERE Phone = '{mobile}'";
                SqlCommand checkMobileCmd = new SqlCommand(checkMobileQuery, con);
                int mobileCount = (int)checkMobileCmd.ExecuteScalar();
                if (mobileCount > 0) { MessageBox.Show("This mobile number is already registered."); return; }
                if (!string.IsNullOrEmpty(email))
                {
                    string checkEmailQuery = $"SELECT COUNT(*) FROM Customer WHERE Email = '{email}'";
                    SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
                    int emailCount = (int)checkEmailCmd.ExecuteScalar();
                    if (emailCount > 0)
                    { MessageBox.Show("This email already exists with a mobile number."); return;}
                }
                string query = $"INSERT INTO Customer (Name, Phone, Email, MembershipType) " +
                               $"VALUES ('{name}', '{mobile}', '{(string.IsNullOrEmpty(email) ? "NULL" : email)}', '{status}')";
                SqlCommand cmd = new SqlCommand(query, con);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0){MessageBox.Show("Customer added successfully!"); }
                else{MessageBox.Show("Failed to add customer."); }
            }
            catch (SqlException ex) { MessageBox.Show("Database error: " + ex.Message); }
            catch (Exception ex) { MessageBox.Show("Unexpected error: " + ex.Message); }
        }

        private void LoadCustomerList()
        { try
            {
                SqlConnection con = new SqlConnection(connectionString);                
                con.Open();
                string query = "SELECT CustomerID, Name, Phone, Email, MembershipType FROM Customer ORDER BY CustomerID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;                    
                
            }
            catch (SqlException ex) { MessageBox.Show("Database error: " + ex.Message); }
            catch (Exception ex) {MessageBox.Show("Unexpected error: " + ex.Message); }
        }
        private void CustomerManagement_Load(object sender, EventArgs e)   { }
        private void homeBtn_Click(object sender, EventArgs e)
        {   Salesman S = new Salesman();           
            S.Show();
            this.Hide();
        }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {   Feedback f = new Feedback();           
            f.Show();
            this.Hide();
        }
        private void pQueryBtn_Click(object sender, EventArgs e)
        {   ProductQuery PQ = new ProductQuery();           
            PQ.Show();
            this.Hide();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.EmployeeId = 0;
            Session.EmployeeName = null;
            LogPage login = new LogPage();           
            login.Show();
            this.Close();
        }
        private void addBtn_Click(object sender, EventArgs e) { AddCustomer(); }
        private void seeBtn_Click(object sender, EventArgs e)    {   LoadCustomerList(); }
        private void clearBtn_Click(object sender, EventArgs e)
        {   nameTxt.Text = "";   mobileTxt.Text = "";    emailTxt.Text = "";     statusTxt.Text = "";     }
        private void benifitBtn_Click(object sender, EventArgs e)
        { string benefits = "Regular Membership:\n" +
                      "1. Basic Access to Services\n" +
                      "2. Cost-Effective\n\n" +
                      "Premium Membership:\n" +
                      "1. Priority Support and Exclusive Features\n" +
                      "2. Enhanced Flexibility and Perks";

            MessageBox.Show(benefits, "Membership Benefits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            PreOrder PO = new PreOrder();           
            PO.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  idTxt.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
            nameTxt.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            mobileTxt.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            statusTxt.Text = dataGridView1.CurrentRow.Cells["MembershipType"].Value.ToString();
        }
        private void UpdateCustomer()
        {
            string customerId = idTxt.Text.Trim();
            string name = nameTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string status = statusTxt.Text.Trim();

            if (string.IsNullOrEmpty(customerId)) { MessageBox.Show("Customer ID is required."); return; }
            if (string.IsNullOrEmpty(name)) {MessageBox.Show("Name cannot be empty.");return; }
            if (string.IsNullOrEmpty(mobile) || mobile.Length < 11) {MessageBox.Show("Mobile must be at least 11 digits."); return; }
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))  {  MessageBox.Show("Enter a valid email containing '@'."); return;  }
            if (string.IsNullOrEmpty(status)) { MessageBox.Show("MemberType status cannot be empty."); return;   }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string checkQuery = $"SELECT COUNT(*) FROM Customer WHERE (Phone='{mobile}' OR Email='{email}') AND CustomerID<>{customerId}";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (count > 0)
            {MessageBox.Show("Another customer already exists with this mobile or email."); con.Close(); return;}
            string updateQuery = $"UPDATE Customer SET Name='{name}', Phone='{mobile}', Email='{email}', MembershipType='{status}' WHERE CustomerID={customerId}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, con);
            int rows = updateCmd.ExecuteNonQuery();

            if (rows > 0) { MessageBox.Show("Customer updated successfully!");}
            else {  MessageBox.Show("Failed to update customer."); }
            con.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e){ UpdateCustomer();}
    }
}
