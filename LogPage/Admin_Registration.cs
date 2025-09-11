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

namespace App
{
    public partial class Admin_Registration : Form
    {
        public string FName, email, DOB, Gender, Qualification, PNumber;

        public void connect()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFName.Text) || 
                    string.IsNullOrWhiteSpace(txtEmail.Text) || 
                    string.IsNullOrWhiteSpace(txtPNumber.Text))
                {
                    MessageBox.Show("Please fill all required fields", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Admin_Registration(FName, PNumber, email, Db, Gender, Qualification) VALUES (@FName, @PNumber, @Email, @DOB, @Gender, @Qualification)";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FName", FName);
                        command.Parameters.AddWithValue("@PNumber", PNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Admin_Registration()
        {
            InitializeComponent();
            txtPNumber.KeyPress += new KeyPressEventHandler(txtPNumber_KeyPress);
            txtPNumber.MaxLength = 5; // Limit phone number to 5 digits
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateFields()) return;

            // Store values
            FName = txtFName.Text.Trim();
            email = txtEmail.Text.Trim();
            PNumber = txtPNumber.Text.Trim();
            DOB = dateTimePicker1.Text;
            Qualification = "";

            // Set gender
            if (rdoMale.Checked)
                Gender = "Male";
            else if (rdoFemale.Checked)
                Gender = "Female";
            else
            {
                MessageBox.Show("Please select Gender", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set qualifications
            if (chkBSc.Checked) Qualification += "BSc ";
            if (chkMSc.Checked) Qualification += "MSc ";
            if (chkPhD.Checked) Qualification += "PhD ";
            Qualification = Qualification.Trim();

            if (string.IsNullOrEmpty(Qualification))
            {
                MessageBox.Show("Please select at least one Qualification", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect();

            Admin_Managed A = new Admin_Managed();
            A.Show();
            this.Hide();
        }

        private void txtPNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Please enter Full Name", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter Email", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPNumber.Text))
            {
                MessageBox.Show("Please enter Phone Number", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPNumber.Focus();
                return false;
            }

            if (txtPNumber.Text.Length != 5 || !txtPNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 5 digits", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPNumber.Focus();
                return false;
            }

            return true;
        }
    }
}
