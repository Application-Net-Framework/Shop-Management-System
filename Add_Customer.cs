using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }
        string connectionString = " Data Source=DESKTOP-ESC3M7E\\SQLEXPRESS;Initial Catalog=DeshiShop;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void ShowCustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CustomerID, Name, Mobile, Email FROM Customer ORDER BY CustomerID DESC"; // latest first
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text.Trim();
            string mobile = mobileTxt.Text.Trim();
            string email = emailTxt.Text.Trim();

            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrEmpty(mobile) || mobile.Length < 10 || !Regex.IsMatch(mobile, @"^[0-9]+$")) { MessageBox.Show("Enter a valid mobile number (only digits, at least 10 numbers)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MessageBox.Show("Enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Customer (Name, Mobile, Email) VALUES (@Name, @Mobile, @Email)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameTxt.Clear();
                        mobileTxt.Clear();
                        emailTxt.Clear();
                    }
                    else { MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){ }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Salesman_Home p = new Salesman_Home();
            p.StartPosition = FormStartPosition.Manual; 
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {  }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Salesman_Home p = new Salesman_Home();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }
    }
}    
