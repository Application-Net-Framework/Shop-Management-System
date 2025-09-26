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
        public string UserID, UserName, Email, PhoneNumber, JoiningDate, Role, Gender;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Full ID is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserID.Focus();
                return;
            }

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

            if (!txtMail.Text.All(char.IsLetter))
            {
                MessageBox.Show("Email must contain only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select Gender", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Full Religion is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }
            



            UserID = txtUserID.Text;
            UserName = txtUserName.Text;
            Email = txtMail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            JoiningDate = dateTimePicker1.Text;
            Role = cmbRole.Text;
            if (rdoMale.Checked)
                Gender = "Male";
            if (rdoFemale.Checked)
                Gender = "Female";
           




            connect();

            /*Admin_Managed A = new Admin_Managed();
            A.Show();
            this.Hide();*/
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

        public void connect()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO AddEmployee(UserID, UserName, Email, PhoneNumber, JoiningDate, Role, Gender ) VALUES ('" + UserID + "','" + UserName + "','" + Email + "','" + PhoneNumber + "','" + JoiningDate + "','" + Role + "','" + Gender + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }
    }
}
