using App.Configuration;
using App.UI_Forms.Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App.UI_Forms.SalesMan
{
    public partial class Profile : Form
    {
        int uId;
        String connectionString = GlobalConfig.ConnectionString;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(int employeeId)
        {
            InitializeComponent(); 
            uId = employeeId;
        }

        private void LoadEmployeeProfile(int userId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT UserName, Email, PhoneNumber, JoiningDate, Role, Gender, Password, Qualification, Address, Religion, DOB FROM Employees WHERE UserID = " + userId;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                userNameTxt.Text = row["UserName"].ToString();
                emailTxt.Text = row["Email"].ToString();
                phoneTxt.Text = row["PhoneNumber"].ToString();
                genderTxt.Text = row["Gender"].ToString();
                passwordTxt.Text = row["Password"].ToString();
                qualificationTxt.Text = row["Qualification"].ToString();
                addressTxt.Text = row["Address"].ToString();
                religionTxt.Text = row["Religion"].ToString();
                
                if (row["DOB"] != DBNull.Value && DateTime.TryParse(row["DOB"].ToString(), out DateTime dob))
                {
                    dobTxt.Text = dob.ToString("yyyy-MM-dd");
                }
                else
                {
                    dobTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No record found for this employee.");
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadEmployeeProfile(uId);
        }

        private void update_Click(object sender, EventArgs e)
        {       if (string.IsNullOrWhiteSpace(userNameTxt.Text) ||
                string.IsNullOrWhiteSpace(emailTxt.Text) ||
                string.IsNullOrWhiteSpace(phoneTxt.Text) ||
                string.IsNullOrWhiteSpace(genderTxt.Text) ||
                string.IsNullOrWhiteSpace(passwordTxt.Text) ||
                string.IsNullOrWhiteSpace(qualificationTxt.Text) ||
                string.IsNullOrWhiteSpace(addressTxt.Text) ||
                string.IsNullOrWhiteSpace(religionTxt.Text) ||
                string.IsNullOrWhiteSpace(dobTxt.Text))
            {
                MessageBox.Show("All fields must be filled before updating the profile.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DateTime dob;
            if (!DateTime.TryParse(dobTxt.Text.Trim(), out dob))
            {
                MessageBox.Show("Invalid Date format. Use YYYY-MM-DD.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "UPDATE Employees SET " +
                           "UserName = '" + userNameTxt.Text.Trim() + "', " +
                           "Email = '" + emailTxt.Text.Trim() + "', " +
                           "PhoneNumber = '" + phoneTxt.Text.Trim() + "', " +
                           "Gender = '" + genderTxt.Text.Trim() + "', " +
                           "Password = '" + passwordTxt.Text.Trim() + "', " +
                           "Qualification = '" + qualificationTxt.Text.Trim() + "', " +
                           "Address = '" + addressTxt.Text.Trim() + "', " +
                           "Religion = '" + religionTxt.Text.Trim() + "', " +
                           "DOB = '" + dob.ToString("yyyy-MM-dd") + "' " +
                           "WHERE UserID = " + uId;

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Salesman s = new Salesman(uId, userNameTxt.Text);
            s.StartPosition = FormStartPosition.Manual;
            s.Location = this.Location;
            s.Size = this.Size;
            s.Show();
            this.Hide();
        }
    }
}
