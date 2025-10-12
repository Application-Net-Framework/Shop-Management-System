using App.Configuration;
using App.UI_Forms.Admin;
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

namespace App.UI_Forms.SalesMan
{
    public partial class Feedback : Form
    {
        public Feedback()
        { InitializeComponent(); }

        string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";

        private void SearchCustomer()
        {
            string searchPhone = searchMobileTxt.Text.Trim();
            if (string.IsNullOrEmpty(searchPhone))
            { MessageBox.Show("Please enter a mobile number."); return; }
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT CustomerID, Name, Phone FROM Customer WHERE Phone LIKE '" + searchPhone + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                { dataGridView1.DataSource = dt; }
                else
                { dataGridView1.DataSource = null; MessageBox.Show("Customer not found."); }
            }
            catch (SqlException ex)
            { MessageBox.Show("Error while searching: " + ex.Message); }
        }

        private void InsertFeedback()
        {
            string customerId = idTxt.Text.Trim();
            string name = nameTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string subject = subjectTxt.Text.Trim();
            string details = detailsTxt.Text.Trim();

            string feedbackType = "";
            if (satisfiedRBtn.Checked) feedbackType = "Satisfied";
            else if (complainRBtn.Checked) feedbackType = "Complaint";
            else if (suggestionBtn.Checked) feedbackType = "Suggestion";

            if (string.IsNullOrEmpty(customerId))
            { MessageBox.Show("Please search and select a valid customer first."); return; }
            if (string.IsNullOrEmpty(name))
            { MessageBox.Show("Name can't be empty."); return; }
            if (string.IsNullOrEmpty(mobile))
            { MessageBox.Show("Mobile can't be empty."); return; }
            if (string.IsNullOrEmpty(feedbackType))
            { MessageBox.Show("Please select a Feedback Type."); return; }
            if (string.IsNullOrEmpty(subject))
            { MessageBox.Show("Please enter a Subject."); return; }
            if (string.IsNullOrEmpty(details))
            { MessageBox.Show("Please enter Details."); return; }

            SqlConnection con = new SqlConnection(connectionString);
            string query = "INSERT INTO Feedback (CustomerID, Name, Mobile, FeedbackType, Subject, Details) " +
                           "VALUES (" + customerId + ",'" + name + "','" + mobile + "','" + feedbackType + "','" + subject + "','" + details + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {   con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback submitted successfully!");
                idTxt.Clear();
                nameTxt.Clear();
                mobileTxt.Clear();
                subjectTxt.Clear();
                detailsTxt.Clear();
                satisfiedRBtn.Checked = complainRBtn.Checked = suggestionBtn.Checked = false;
            }
            catch (SqlException ex)
            { MessageBox.Show("Error saving feedback: " + ex.Message); }
        }

        private void LoadAllFeedbacks()
        {
            try
            {   SqlConnection con = new SqlConnection(connectionString);
                string query = "SELECT FeedbackID, CustomerID, Name, Mobile, FeedbackType, Subject, Details, Response, FeedbackDate FROM Feedback ORDER BY FeedbackDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                feedbackDataGridView.DataSource = dt;
                feedbackDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (SqlException ex)
            { MessageBox.Show("Error loading feedback: " + ex.Message); }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {   Salesman S = new Salesman();            
            S.Show();
            this.Hide();
        }
        private void pQueryBtn_Click(object sender, EventArgs e)
        {   ProductQuery PQ = new ProductQuery();           
            PQ.Show();
            this.Hide();
        }
        private void cManagementBtn_Click(object sender, EventArgs e)
        {   CustomerManagement CM = new CustomerManagement();           
            CM.Show();
            this.Hide();
        }
        private void submitBtn_Click(object sender, EventArgs e) { InsertFeedback(); }
        private void feedbackRecordBtn_Click(object sender, EventArgs e) { LoadAllFeedbacks(); }
        private void preOrderBtn_Click(object sender, EventArgs e)
        {   PreOrder PO = new PreOrder();         
            PO.Show();
            this.Hide();
        }
        private void searchBtn_Click(object sender, EventArgs e) { SearchCustomer(); }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {   CustomerManagement CM = new CustomerManagement();           
            CM.Show();
            this.Hide();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   idTxt.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
            nameTxt.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            mobileTxt.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
        }
        private void feedbackDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {   fIdTxt.Text = feedbackDataGridView.CurrentRow.Cells["FeedbackID"].Value.ToString();
            cIdTxt.Text = feedbackDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            mTxt.Text = feedbackDataGridView.CurrentRow.Cells["Mobile"].Value.ToString();
            nTxt.Text = feedbackDataGridView.CurrentRow.Cells["Name"].Value.ToString();
        }
        private void repsonseBtn_Click(object sender, EventArgs e)
        {
            string feedbackId = fIdTxt.Text.Trim();
            string customerId = cIdTxt.Text.Trim();
            string name = nTxt.Text.Trim();
            string mobile = mTxt.Text.Trim();
            string response = responseTxt.Text.Trim();

            if (string.IsNullOrEmpty(feedbackId))
            { MessageBox.Show("Feedback ID is required."); return; }
            if (string.IsNullOrEmpty(customerId)) { MessageBox.Show("Customer ID is required."); return; }
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Customer Name is required."); return; }
            if (string.IsNullOrEmpty(mobile)) { MessageBox.Show("Customer Mobile is required."); return; }
            if (string.IsNullOrEmpty(response)) { MessageBox.Show("Please enter a Response & Solution."); return; }
            SqlConnection con = new SqlConnection(connectionString);
            string query = "UPDATE Feedback SET Response = '" + response + "' " +
                           "WHERE FeedbackID = " + feedbackId + " AND CustomerID = " + customerId;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {   con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0) { MessageBox.Show("Response updated successfully!"); responseTxt.Clear(); }
                else { MessageBox.Show("No matching feedback record found."); }
            }
            catch (SqlException ex) { MessageBox.Show("Error while updating response: " + ex.Message); }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {   Session.EmployeeId = 0;
            Session.EmployeeName = null;
            LogPage login = new LogPage();            
            login.Show();
            this.Close();
        }
    }
}
