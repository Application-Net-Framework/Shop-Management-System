using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        private void SaveEmployee()
        {
            string userId = idTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string address = addressTxt.Text.Trim();
            string education = educationCBox.Text.Trim();
            string pass = passTxt.Text.Trim();
            string confirmPass = confirmPassTxt.Text.Trim();
            DateTime dob = dobDate.Value;
            string gender = maleRBtn.Checked ? "Male" : femaleRBtn.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(email))
            { MessageBox.Show("User ID and Email are required."); return; }
            if (pass != confirmPass)
            { MessageBox.Show("Passwords do not match."); return; }
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM Employees WHERE UserID='" + userId + "' AND Email='" + email + "'", con).ExecuteScalar()) == 0)
                { MessageBox.Show("UserID and Email do not match any record."); return; }
                string updateQuery = "UPDATE Employees SET " +
                                     "PhoneNumber = " + (string.IsNullOrEmpty(mobile) ? "NULL" : "'" + mobile + "'") + "," +
                                     "Gender = " + (string.IsNullOrEmpty(gender) ? "NULL" : "'" + gender + "'") + "," +
                                     "Address = " + (string.IsNullOrEmpty(address) ? "NULL" : "'" + address + "'") + "," +
                                     "Qualification = " + (string.IsNullOrEmpty(education) ? "NULL" : "'" + education + "'") + "," +
                                     "DOB = " + (dob == DateTime.MinValue ? "NULL" : "'" + dob.ToString("yyyy-MM-dd") + "'") + "," +
                                     "Password = '" + pass + "' " +
                                     "WHERE UserID='" + userId + "' AND Email='" + email + "'";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                { MessageBox.Show("Employee data updated successfully!"); ClearInputs(); }
                else
                { MessageBox.Show("Update failed."); }
            }
            catch (SqlException ex)
            { MessageBox.Show("Database Error: " + ex.Message); }
        }

        private void ClearInputs()
        {
            idTxt.Clear();
            emailTxt.Clear();
            mobileTxt.Clear();
            addressTxt.Clear();
            educationCBox.SelectedIndex = -1;
            passTxt.Clear();
            confirmPassTxt.Clear();
            maleRBtn.Checked = false;
            femaleRBtn.Checked = false;
            dobDate.Value = DateTime.Today;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void securityQuesLbl_Click(object sender, EventArgs e) { }
        private void empSerialLbl_Click(object sender, EventArgs e) { }
        private void backBtn_Click(object sender, EventArgs e)
        {
            LogPage homeForm = new LogPage();
            homeForm.Show();
            this.Hide();
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        { SaveEmployee(); }
    }

}
