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
        private void show1_Click(object sender, EventArgs e)
        {

        }
        public string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";

        public string UserName;
        public string PhoneNumber;
        public string Email;
        public string Address;
        public string Password;
        public string PreviousPassword;
        public string Gender;
        public string Qualification;
        public DateTime DOB;
        public int Age;
        public int UserID;

        private int userId;
        public void UIRefreash()
        {
            invalidUsernamelb.Visible = false;
            invalidphonelb.Visible = false;
            invemaillb.Visible = false;
            invalidpasswodlb.Visible = false;
            invalidretypelb.Visible = false;
            invalidpreviouspasslb.Visible = false;
            invalidaddresslb.Visible = false;
            dobLb.Visible = false;

            show1.Visible = false;
            show2.Visible = false;
            show3.Visible = false;
            newPasswordpanel.Visible = false;


            aboutNewPass.Text = "";
            aboutRePass.Text = "";
            aboutPrePass.Text = "";
        }
        public about(int userId)
        {
            InitializeComponent();
            this.userId = userId;


            UIRefreash();
            LoadUserDataById(userId);

            QulifiShow.Text = Qualification;
            genderLb.Text = Gender;
            agelb.Text = Age.ToString();
        }
        private void passwordChangelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newPasswordpanel.Visible = true;
            passwordChangelb.Visible = false;
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newPasswordpanel.Visible = false;
            passwordChangelb.Visible = true;
        }
        private void Hidelb_Click(object sender, EventArgs e)
        {
            aboutPrePass.UseSystemPasswordChar = false;
            Showlb.Visible = true;
            Hidelb.Visible = false;

        }

        private void Showlb_Click(object sender, EventArgs e)
        {
            aboutPrePass.UseSystemPasswordChar = true;
            Showlb.Visible = false;
            Hidelb.Visible = true;
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            aboutNewPass.UseSystemPasswordChar = false;
            show2.Visible = true;
            hide2.Visible = false;
        }

        private void show2_Click(object sender, EventArgs e)
        {
            aboutNewPass.UseSystemPasswordChar = true;
            show2.Visible = false;
            hide2.Visible = true;
        }

        private void hide3_Click(object sender, EventArgs e)
        {
            aboutRePass.UseSystemPasswordChar = false;
            show3.Visible = true;
            hide3.Visible = false;
        }

        private void show3_Click(object sender, EventArgs e)
        {
            aboutRePass.UseSystemPasswordChar = true;
            show3.Visible = false;
            hide3.Visible = true;
        }

        public about()
        {
            InitializeComponent();
        }

        
        private void LoadUserDataById(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string selectQuery = "SELECT UserID, UserName, PhoneNumber, Email, DOB, Address, Gender, Password, Qualification FROM Employees WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        UserName = reader["UserName"].ToString();
                        PhoneNumber = reader["PhoneNumber"].ToString();
                        Email = reader["Email"].ToString();
                        DOB = Convert.ToDateTime(reader["DOB"]);
                        Address = reader["Address"].ToString();
                        Gender = reader["Gender"].ToString();
                        Password = reader["Password"].ToString();
                        Qualification = reader["Qualification"].ToString();
                        UserID = Convert.ToInt32(reader["UserID"]);

                        PopulateFormControls();
                    }
                    else
                    {
                        MessageBox.Show("User not found with ID: " + userId, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool IsDataChanged()
        {
            return UserName != aboutTxtboxName.Text ||
                   PhoneNumber != aboutPhoneTxt.Text ||
                   Email != aboutEmailTxt.Text ||
                   DOB != dateTimePicker1.Value ||
                   Address != aboutAddressTxt.Text ||
                   Gender != genderLb.Text ||
                   Qualification != QulifiShow.Text ||
                   (aboutNewPass.Text != "" && Password != aboutNewPass.Text); 
        }

        public void refreashData()
        {
            aboutNewPass.Text = "";
            aboutRePass.Text = "";
            aboutPrePass.Text = "";

            Age = calculateAge(DOB);
            agelb.Text = Age.ToString();
            LoadUserDataById(userId);
           
        }
        
        private void PopulateFormControls()
        {
            if (aboutTxtboxName != null) aboutTxtboxName.Text = UserName;
            if (aboutPhoneTxt != null) aboutPhoneTxt.Text = PhoneNumber;
            if (aboutEmailTxt != null) aboutEmailTxt.Text = Email;
            if (aboutAddressTxt != null) aboutAddressTxt.Text = Address;
            if (dateTimePicker1 != null) dateTimePicker1.Value = DOB;
            if(UserID!=0) usrIdlbl.Text = UserID.ToString();
        }

        private bool SaveUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string updateQuery = @"UPDATE Employees SET 
                         UserName = @UserName,
                         PhoneNumber = @PhoneNumber,
                         Email = @Email,
                         DOB = @DOB,
                         Address = @Address,
                         Gender = @Gender,
                         Password = @Password,
                         Qualification = @Qualification
                         WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", aboutPhoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Email", aboutEmailTxt.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Address", aboutAddressTxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Qualification", Qualification); 

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    UIRefreash();
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
            if (!double.TryParse(aboutPhoneTxt.Text, out input) || aboutPhoneTxt.TextLength!=11)
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
            aboutPrePass.UseSystemPasswordChar = true;
            Showlb.Visible = false;
            Hidelb.Visible = true;
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
            aboutNewPass.UseSystemPasswordChar = true;
            hide2.Visible = true;
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
            aboutRePass.UseSystemPasswordChar = true;
            if (aboutNewPass.Text != aboutRePass.Text)
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
            if(age < 18 || age > 100)
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
            Age = age;
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
                    if(!IsDataChanged())
                    {
                        MessageBox.Show("No changes were made.", "Information",
                              MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                        return;
                    }
                    else {
                        if (result == DialogResult.Yes)
                        {
                            if (!string.IsNullOrEmpty(aboutPrePass.Text))
                            {
                                MessageBox.Show("Changes applied successfully!",
                                                "Success",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                PhoneNumber = aboutPhoneTxt.Text;
                                Email = aboutEmailTxt.Text;
                                DOB = dateTimePicker1.Value;
                                Address = aboutAddressTxt.Text;
                                UserName = aboutTxtboxName.Text;

                                if (!string.IsNullOrEmpty(aboutNewPass.Text))
                                {
                                    Password = aboutNewPass.Text;
                                }

                                SaveUserData(); 
                                refreashData();
                            }
                        }
                    }
                }
            }
        }


    }
}
