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
    public partial class Registration_Admin : Form
    {
        public string Full_Name, Email, Phone_Number, DOB, Gender, Qualification, Religion,Address, Password, Retype_Password;
        public void connect()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO Admin_Registration(Full_Name, Email, PHone_Number, DOB, Gender, Qualification, Religion, Address ) VALUES ('" + Full_Name + "','" + Email + "','" + Phone_Number + "','" + DOB + "','" + Gender + "','" + Qualification + "','" + Religion + "','" + Address + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public Registration_Admin()
        {
            InitializeComponent();
            //txtPNumber.KeyPress += new KeyPressEventHandler(txtPNumber_KeyPress);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblReligion_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMSc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Full Name is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFName.Focus();
                return;
            }


            if (!txtFName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Name must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!txtEmail.Text.All(char.IsLetter))
            {
                MessageBox.Show("Email must contain only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            


            if (string.IsNullOrWhiteSpace(txtPNumber.Text))
            {
                MessageBox.Show("Phone Number is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPNumber.Focus();
                return;
            }


            if (!txtPNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPNumber.Focus();
                return;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select Gender", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!chkBSc.Checked && !chkMSc.Checked && !chkPhD.Checked)
            {
                MessageBox.Show("Please select at least one Qualification", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Full Address is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (!txtAddress.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Address must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbReligion.Text))
            {
                MessageBox.Show("Full Religion is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Full Password is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }


            if (!txtPass.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Password must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRePass.Text))
            {
                MessageBox.Show("Full Retype Password is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePass.Focus();
                return;
            }


            if (!txtRePass.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Retype Password must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePass.Focus();
                return;
            }

            Full_Name = txtFName.Text;
            Email = txtEmail.Text;
            Phone_Number = txtPNumber.Text;
            DOB = dateTimePicker1.Text;
            Religion = cmbReligion.Text;
            Address = txtAddress.Text;
            Qualification = "";
            Password = txtPass.Text;
            Retype_Password = txtRePass.Text;

            if (rdoMale.Checked)
                Gender = "Male";
            if (rdoFemale.Checked)
                Gender = "Female";

            if (chkBSc.Checked)
                Qualification += "BSc";
            if (chkMSc.Checked)
                Qualification += "MSc";
            if (chkPhD.Checked)
                Qualification += "PhD";

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

        
            /*private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;

            }
        }*/
    }
}