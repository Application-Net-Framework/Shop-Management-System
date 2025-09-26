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
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace App
{

    public partial class LogPage : Form
    {


        public LogPage()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";


        private string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        private void login()
        {
            string email = emailTxt.Text.Trim();
            string password = passTxt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT UserID, UserName, Role 
                                 FROM Employees 
                                 WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserID"]);
                            string userName = reader["UserName"].ToString();
                            string role = reader["Role"].ToString();

                            MessageBox.Show("Login Successful! Welcome " + userName);

                            // Redirect based on Role
                            Form nextForm = null;
                            if (role == "Admin")
                                nextForm = new Admin_Home();
                            //nextForm = new Admin_Home(userId, userName);
                            else if (role == "Manager")
                                nextForm = new Manager_Home();
                           // nextForm = new Manager_Home(userId, userName);
                            else if (role == "Cashier")
                            {
                                nextForm = new Cashier();
                                //nextForm = new Cashier(userId, userName);
                            }
                            else if (role == "Salesman")
                                nextForm = new Salesman();
                            //nextForm = new Salesman(userId, userName);
                            else
                            {
                                MessageBox.Show("Role not recognized. Contact admin.");
                                return;
                            }

                            nextForm.StartPosition = FormStartPosition.Manual;
                            nextForm.Location = this.Location;
                            nextForm.Size = this.Size;

                            nextForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password.");
                        }
                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }


















        private void logBtn_Click(object sender, EventArgs e)
        {
            login();
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration homeForm = new Registration();
            homeForm.Show();
            this.Hide();
        }

        private void fPassBtn_Click(object sender, EventArgs e)
        {

            ForgetPass homeForm = new ForgetPass();
            homeForm.Show();
            this.Hide();
        }

        private void uNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void uNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passBtn_Click(object sender, EventArgs e)
        {

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void messageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
