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
        public string FName, email, Db, Gender, Qualification, PNumber;
        public void connect()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO Admin_Registration(FName, PNumber, email, Db, Gender,Qualification) VALUES ('" + FName + "','" + PNumber + "','" + email + "','" + Db + "','" + Gender + "','" + Qualification + "')";
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
            txtPNumber.KeyPress += new KeyPressEventHandler(txtPNumber_KeyPress);
        }

        private void label1_Click(object sender, EventArgs e)
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
            
            if (!txtFName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Full Name must contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFName.Focus();
                return;
            }

            
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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


            FName = txtFName.Text;
            email = txtEmail.Text;
            PNumber = txtPNumber.Text;
            Db = dateTimePicker1.Text;
            Qualification = "";

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

        
        private bool IsValidEmail(string email)
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
        }
    }
}