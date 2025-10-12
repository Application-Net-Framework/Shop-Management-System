using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Admin.Features
{
    public partial class addEmployee : UserControl
    {
        public string UserName, Email, PhoneNumber, Role;
        public DateTime JoiningDate;

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Form parentForm = this.FindForm();
            
            
            if (parentForm != null && parentForm is Admin.Admin_Main_Home)
            {
                
                this.Visible = false;
                
                
                Control home1Control = null;
                foreach (Control control in parentForm.Controls.Find("featurePanel", true)[0].Controls)
                {
                    if (control.Name == "home1")
                    {
                        home1Control = control;
                        break;
                    }
                }
                
                if (home1Control != null)
                {
                    home1Control.Visible = true;
                    home1Control.BringToFront();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Full Name is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (!txtUserName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Name must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Email is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return;
            }

            if (!txtMail.Text.Contains("@") || !txtMail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            if (!txtPhoneNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Role is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }
            
            UserName = txtUserName.Text;
            Email = txtMail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            JoiningDate = dateTimePicker1.Value;
            Role = cmbRole.Text;
           
            
            if (connect())
            {
                
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                ClearFields();
            }
        }

        
        private void ClearFields()
        {
            txtUserName.Clear();
            txtMail.Clear();
            txtPhoneNumber.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbRole.SelectedIndex = -1;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public addEmployee()
        {
            InitializeComponent();
        }

        public bool connect()
        {
            try
            {
                string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    
                    string query = "INSERT INTO Employees(UserName, Email, PhoneNumber, JoiningDate, Role) VALUES (@UserName, @Email, @PhoneNumber, @JoiningDate, @Role)";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@JoiningDate", JoiningDate); 
                        command.Parameters.AddWithValue("@Role", Role);
                        
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            
        }
    }
}
