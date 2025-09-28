using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App.UI_Forms.Manager
{
    public partial class about : UserControl
    {

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";

        public string UserName;
        public string PhoneNumber;
        public string Email;
        public string Address;
        public string Password;
        public string PreviousPassword;
        public string Gender;
        public string Qualification;
        public DateTime DateOfBirt;  

        public about()
        {
            InitializeComponent();

            invalidUsernamelb.Visible = false;
            invalidphonelb.Visible = false;
            invemaillb.Visible = false;
            invalidpasswodlb.Visible = false;
            invalidretypelb.Visible = false;
            invalidpreviouspasslb.Visible = false;
            invalidaddresslb.Visible = false;
            dobLb.Visible = false;

            LoadUserData();

            QulifiShow.Text = Qualification;
            genderLb.Text = Gender;
            

        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string selectQuery = "SELECT  UserName, PhoneNumber, Email, DateOfBirt, Address, Gender, Password, Qulification FROM Employee";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        UserName = reader["UserName"].ToString();
                        PhoneNumber = reader["PhoneNumber"].ToString();
                        Email = reader["Email"].ToString();
                        DateOfBirt = Convert.ToDateTime(reader["DateOfBirt"]);
                        Address = reader["Address"].ToString();
                        Gender = reader["Gender"].ToString();
                        Password = reader["Password"].ToString();
                        Qualification = reader["Qulification"].ToString();

                        // Populate form controls with loaded data
                        PopulateFormControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFormControls()
        {
            if (aboutTxtboxName != null) aboutTxtboxName.Text = UserName;
            if (aboutPhoneTxt != null) aboutPhoneTxt.Text = PhoneNumber;
            if (aboutEmailTxt != null) aboutEmailTxt.Text = Email;
            if (aboutAddressTxt != null) aboutAddressTxt.Text = Address;
            if (dateTimePicker1 != null) dateTimePicker1.Value = DateOfBirt;
        }

        private bool SaveUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string updateQuery = @"UPDATE Employee SET 
                                         PhoneNumber = @PhoneNumber,
                                         Email = @Email,
                                         DateOfBirt = @DateOfBirt,
                                         Address = @Address,
                                         Gender = @Gender,
                                         Password = @Password,
                                         Qulification = @Qulification
                                         WHERE UserName = @UserName";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", aboutPhoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Email", aboutEmailTxt.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirt", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Address", aboutAddressTxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Qulification", Qualification);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void aboutTxtboxName_TextChanged(object sender, EventArgs e)
        {
            double input;
            if(double.TryParse(aboutTxtboxName.Text, out input))
            {
                invalidUsernamelb.Visible = true;
            }
            else {
                invalidUsernamelb.Visible = false;
            }

        }

        private void aboutPhoneTxt_TextChanged(object sender, EventArgs e)
        {
            double input;
            if (!double.TryParse(aboutPhoneTxt.Text, out input))
            {
                invalidphonelb.Visible = true;
            }
            else
            {
                invalidphonelb.Visible = false;
            }
        }

        private void aboutEmailTxt_TextChanged(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(aboutEmailTxt.Text, out input))
            {
                invemaillb.Visible = true;
            }
            else
            {
                invemaillb.Visible = false;
            }
        }

        private void aboutAddressTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutPrePass_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(aboutPrePass.Text))
            {
                if (aboutPrePass.Text != Password)
                {
                    invalidpreviouspasslb.Visible = true;
                }
                else
                {
                    invalidpreviouspasslb.Visible = false;
                }
            }
        }

        private void aboutNewPass_TextChanged(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(aboutNewPass.Text))
            {
                if (aboutNewPass.Text==Password)
                {
                    invalidpasswodlb.Visible = true;
                }
                else
                {
                    invalidpasswodlb.Visible = false;
                }
            }
        }

        private void aboutRePass_TextChanged(object sender, EventArgs e)
        {
            if(aboutNewPass.Text != aboutRePass.Text)
            {
                invalidretypelb.Visible = true;
            }
            else
            {
                invalidretypelb.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            int age = calculateAge(dob);
            if(age < 18)
            {
                dobLb.Visible = true;
            }
            else
            {
                dobLb.Visible = false;
            }

        }
        private int calculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }

        private void QulifiShow_Click(object sender, EventArgs e)
        {
            QulifiShow.Text = Qualification;
        }

        private void genderLb_Click(object sender, EventArgs e)
        {
            genderLb.Text = Gender;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (invalidUsernamelb.Visible ||  invalidphonelb.Visible || invemaillb.Visible || invalidpasswodlb.Visible ||  invalidretypelb.Visible ||  invalidpreviouspasslb.Visible ||   invalidaddresslb.Visible ||   dobLb.Visible)
            {
                MessageBox.Show("Please fulfill the requirements.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                if (aboutPrePass.Text != Password)
                {
                    MessageBox.Show("Please enter the correct previous password.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to change?",
                                                          "Confirm",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(aboutNewPass.Text))
                        {
                            MessageBox.Show("Changes applied successfully!",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            PhoneNumber = aboutPhoneTxt.Text;
                            Email = aboutEmailTxt.Text;
                            DateOfBirt = dateTimePicker1.Value;
                            Address = aboutAddressTxt.Text;
                            if (!string.IsNullOrEmpty(aboutNewPass.Text))
                            {
                                Password = aboutNewPass.Text;
                            }
                            SaveUserData();

                        }
                        else
                        {
                            MessageBox.Show("Failed to save changes. Please try again.",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
