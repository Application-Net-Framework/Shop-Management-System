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
        string connectionString= @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private void SaveEmployee()
        {   string userId = idTxt.Text.Trim();            
            string email = emailTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string address = addressTxt.Text.Trim();
            string education = educationCBox.Text.Trim();
            string pass = passTxt.Text.Trim();
            string confirmPass = confirmPassTxt.Text.Trim();
            DateTime dob = dobDate.Value;
            string gender = maleRBtn.Checked ? "Male" : femaleRBtn.Checked ? "Female" : "";

           
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(email)) {  MessageBox.Show("User ID and Email are required.");  return; }
           
            if (pass != confirmPass) {  MessageBox.Show("Passwords do not match.");  return;}
                     
            string hashedPassword = HashPassword(pass);

            SqlConnection con = new SqlConnection(connectionString);
            try
                {con.Open();                    
                 string checkQuery = "SELECT COUNT(*) FROM Employees WHERE UserID=@UserID AND Email=@Email";
                 SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    
                 checkCmd.Parameters.AddWithValue("@UserID", userId);
                 checkCmd.Parameters.AddWithValue("@Email", email);

                 int exists = (int)checkCmd.ExecuteScalar();
                 if (exists == 0){ MessageBox.Show("UserID and Email do not match any record."); return; }                   
                  string updateQuery = @"UPDATE Employees
                                   SET PhoneNumber=@PhoneNumber,
                                       Gender=@Gender,
                                       Address=@Address,
                                       Qualification=@Qualification,
                                       DOB=@DOB,
                                       Password=@Password
                                   WHERE UserID=@UserID AND Email=@Email";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Email", email);                        
                        cmd.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrEmpty(mobile) ? (object)DBNull.Value : mobile);
                        cmd.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(gender) ? (object)DBNull.Value : gender);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@Qualification", string.IsNullOrEmpty(education) ? (object)DBNull.Value : education);
                        cmd.Parameters.AddWithValue("@DOB", dob == DateTime.MinValue ? (object)DBNull.Value : dob);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) {MessageBox.Show("Employee data updated successfully!"); ClearInputs(); }
                        else{ MessageBox.Show("Update failed."); }
                    }
                }
                catch (SqlException ex) {MessageBox.Show("Database Error: " + ex.Message);}
            }      
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        private void ClearInputs()
        {   idTxt.Clear();            
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






















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void securityQuesLbl_Click(object sender, EventArgs e)
        {

        }

        private void empSerialLbl_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LogPage homeForm = new LogPage();
            homeForm.Show();
            this.Hide();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }
    }
}
