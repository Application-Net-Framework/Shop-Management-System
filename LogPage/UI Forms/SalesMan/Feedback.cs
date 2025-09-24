using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace App.UI_Forms.SalesMan
{
    public partial class Feedback : Form
    {
        
        public Feedback()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;   // or AutoScaleMode.Font
            this.AutoSize = true;
        }

        String connectionString = @"Data Source=DESKTOP-ESC3M7E\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void InsertFeedback()
        {
            // 1️⃣ Get values from form controls
            string customerMobile = mobileTxt.Text.Trim();
            string subject = subjectTxt.Text.Trim();
            string details = detailsTxt.Text.Trim();

            // Determine feedback type from RadioButtons
            string feedbackType = "";
            if (satisfiedRBtn.Checked) feedbackType = "Satisfied";
            else if (complainRBtn.Checked) feedbackType = "Complaint";
            else if (suggestionBtn.Checked) feedbackType = "Suggestion";

            // 2️⃣ Validation
            if (string.IsNullOrEmpty(customerMobile))
            {
                MessageBox.Show("Please enter Customer Mobile.");
                return;
            }
            if (string.IsNullOrEmpty(feedbackType))
            {
                MessageBox.Show("Please select a Feedback Type.");
                return;
            }
            if (string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please enter a Subject.");
                return;
            }
            if (string.IsNullOrEmpty(details))
            {
                MessageBox.Show("Please enter Details.");
                return;
            }

            // 3️⃣ Insert into database
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Feedback (CustomerMobile, FeedbackType, Subject, Details)
                         VALUES (@CustomerMobile, @FeedbackType, @Subject, @Details)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerMobile", customerMobile);
                    cmd.Parameters.AddWithValue("@FeedbackType", feedbackType);
                    cmd.Parameters.AddWithValue("@Subject", subject);
                    cmd.Parameters.AddWithValue("@Details", details);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Feedback submitted successfully!");

                        // Optional: clear inputs after submission
                        mobileTxt.Clear();
                        subjectTxt.Clear();
                        detailsTxt.Clear();
                        satisfiedRBtn.Checked = complainRBtn.Checked = suggestionBtn.Checked = false;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error saving feedback: " + ex.Message);
                    }
                }
            }
        }



        private void LoadAllFeedbacks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT FeedbackID, CustomerMobile, FeedbackType, Subject, Details, FeedbackDate FROM Feedback ORDER BY FeedbackDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    feedbackDataGridView.DataSource = dt;  // feedbackDataGridView is your DataGridView control
                    feedbackDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }










        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman S= new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            InsertFeedback();
        }

        private void feedbackRecordBtn_Click(object sender, EventArgs e)
        {
            LoadAllFeedbacks();
;        }

        private void discountBtn_Click(object sender, EventArgs e)
        {

            DiscountSuggestion DS = new DiscountSuggestion();
            DS.StartPosition = FormStartPosition.Manual;
            DS.Location = this.Location;
            DS.Size = this.Size;
            DS.Show();
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
    }
}
