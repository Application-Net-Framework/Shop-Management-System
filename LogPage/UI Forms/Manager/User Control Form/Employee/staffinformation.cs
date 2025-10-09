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

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class staffinformation : UserControl
    {
        public string username;
        public string phonenum;
        public string email;
        public string qulification;
        public string address;
        public string title;
        public string gender;
        public int userId;
        public DateTime dob;
        public int age;

        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public void LoadUI()
        {
            invalidUsernamelb.Visible = false;
            invalidphonelb.Visible = false;
            invalidDatelb.Visible = false;
  

            SaleManPicturebox.Visible = false;
            cashierpicturebox.Visible = false;
            demopicturebox.Visible = true;

            informationEmployeeDataGrid.BackgroundColor = Color.White;
            informationEmployeeDataGrid.GridColor = Color.LightGray;

            
            informationEmployeeDataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            informationEmployeeDataGrid.RowsDefaultCellStyle.ForeColor = Color.Black;

            
            informationEmployeeDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            informationEmployeeDataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            
            informationEmployeeDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            informationEmployeeDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            informationEmployeeDataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            informationEmployeeDataGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

           
            informationEmployeeDataGrid.EnableHeadersVisualStyles = false;
            informationEmployeeDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            informationEmployeeDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            informationEmployeeDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            updatebtn.MouseEnter += updatebtn_MouseEnter;
            updatebtn.MouseLeave += updatebtn_MouseLeave;

            tarminationbtn.MouseEnter += tarminationbtn_MouseEnter;
            tarminationbtn.MouseLeave += tarminationbtn_MouseLeave;
            fun1.Visible = false;
            fun2.Visible = false;
        }
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            return age;
        }
        public void imageLoader()
        {
            if(title == "Salesman")
            {
                SaleManPicturebox.Visible = true;
                cashierpicturebox.Visible = false;
                demopicturebox.Visible = false;
            }
            else if(title == "Cashier")
            {
                SaleManPicturebox.Visible = false;
                cashierpicturebox.Visible = true;
                demopicturebox.Visible = false;
            }
            else
            {
                SaleManPicturebox.Visible = false;
                cashierpicturebox.Visible = false;
                demopicturebox.Visible = true;
            }
        }
        public staffinformation()
        {
            InitializeComponent();

            LoadUI();
            ClearFormFields();



        }


   
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text.Length <= 0)
            {
                DataGridviewDesign();
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        string query = "SELECT userID, userName, Role FROM Employee WHERE AccountStatus = 'active' AND (CAST(userID AS NVARCHAR) LIKE @Search OR userName LIKE @Search)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchbox.Text + "%");
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                informationEmployeeDataGrid.DataSource = dt;
                                informationEmployeeDataGrid.Height = 30 * dt.Rows.Count;
                            }
                            else
                            {
                                DataGridviewDesign();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
            }
        }

        private void staffinformationPanel_Paint(object sender, PaintEventArgs e) { }
        private void updatebtn_MouseEnter(object sender, EventArgs e)
        {
            fun1.Visible = true;
        }
        private void updatebtn_MouseLeave(object sender, EventArgs e)
        {
            fun1.Visible = false;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userId <= 0)
                {
                    MessageBox.Show("Please select an employee to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Employee SET 
                                   userName = @userName,
                                   PhoneNumber = @PhoneNumber,
                                   DateOfBirt = @DateOfBirt
                                   WHERE userID = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.Parameters.AddWithValue("@userName", aboutTxtboxName.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", aboutPhoneTxt.Text);
                        cmd.Parameters.AddWithValue("@Email", aboutEmailTxt.Text);
                        cmd.Parameters.AddWithValue("@Address", aboutAddressTxt.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirt", dobtime.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }
        private void tarminationbtn_MouseEnter(object sender, EventArgs e)
        {
            fun2.Visible = true;
        }
        private void tarminationbtn_MouseLeave(object sender, EventArgs e)
        {
            fun2.Visible = false;
        }
        private void tarminationbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userId <= 0)
                {
                    MessageBox.Show("Please select an employee to terminate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to terminate employee '{username}'?\n\nThis will deactivate their account.", 
                    "Confirm Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open(); 
                        string query = "UPDATE Employee SET AccountStatus = 'deactive' WHERE userID = @userID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userID", userId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee terminated successfully! Account status changed to deactive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                ClearFormFields();
                 
                            }
                            else
                            {
                                MessageBox.Show("Employee not found or already terminated.", "Termination Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error terminating employee: " + ex.Message);
            }
        }

        private void ClearFormFields()
        {
            userId = 0;
            username = "";
            title = "";
            phonenum = "";
            email = "";
            address = "";
            gender = "";
            qulification = "";
            
            usrIdlbl.Text = "";
            titleShow.Text = "";
            aboutTxtboxName.Text = "";
            aboutPhoneTxt.Text = "";
            aboutEmailTxt.Text = "";
            aboutAddressTxt.Text = "";
            genderLb.Text = "";
            QulifiShow.Text = "";
            agelb.Text = "";
            
            
            SaleManPicturebox.Visible = false;
            cashierpicturebox.Visible = false;
            demopicturebox.Visible = true;
        }

        public void loadTextBoxInformation()
        {
            titleShow.Text = title;
            usrIdlbl.Text = userId.ToString();
            aboutTxtboxName.Text = username;
            aboutPhoneTxt.Text = phonenum;
            aboutEmailTxt.Text = email;
            aboutAddressTxt.Text = address;
            dobtime.Value = dob;
            agelb.Text = age.ToString();
        }
        private void aboutTxtboxName_TextChanged(object sender, EventArgs e) {
           string Text = aboutTxtboxName.Text;
            if (string.IsNullOrWhiteSpace(Text) || Text.Any(char.IsDigit))
              {
                invalidUsernamelb.Visible = true;
              }
              else
              {
                invalidUsernamelb.Visible = false;
            }
        }
        private void aboutPhoneTxt_TextChanged(object sender, EventArgs e) {
            string Text = aboutPhoneTxt.Text;
            if (string.IsNullOrWhiteSpace(Text) || !Text.All(char.IsDigit) || Text.Length < 10)
            {
                invalidphonelb.Visible = true;
            }
            else
            {
                invalidphonelb.Visible = false;
            }
        }
        private void aboutAddressTxt_TextChanged(object sender, EventArgs e) { }
        public void DataGridviewDesign()
        {
           informationEmployeeDataGrid.DataSource = null;
           informationEmployeeDataGrid.Height = 3;
        }
        private void informationEmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = informationEmployeeDataGrid.Rows[e.RowIndex];
                    
                    int selectedUserId = Convert.ToInt32(row.Cells["userID"].Value);
                    
                    LoadEmployeeDetails(selectedUserId);
                    DataGridviewDesign();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting employee: " + ex.Message);
                }
            }
        }

        private void LoadEmployeeDetails(int selectedUserId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT userID, userName, Role, PhoneNumber, Email, Qulification, Address, Gender, DateOfBirt FROM Employee WHERE userID = @UserId AND AccountStatus = 'active'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                this.userId = Convert.ToInt32(reader["userID"]);
                                username = reader["userName"]?.ToString() ?? "";
                                title = reader["Role"]?.ToString() ?? "";
                                phonenum = reader["PhoneNumber"]?.ToString() ?? "";
                                email = reader["Email"]?.ToString() ?? "";
                                qulification = reader["Qulification"]?.ToString() ?? "";
                                address = reader["Address"]?.ToString() ?? "";
                                gender = reader["Gender"]?.ToString() ?? "";
                                
                                if (reader["DateOfBirt"] != DBNull.Value)
                                {
                                    dob = Convert.ToDateTime(reader["DateOfBirt"]);
                                    age = CalculateAge(dob);
                                }
                                else
                                {
                                    dob = DateTime.Now;
                                    age = 0;
                                }
  
                                loadTextBoxInformation();
                                imageLoader();
                  
                                genderLb.Text = gender;
                                QulifiShow.Text = qulification;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee details: " + ex.Message);
            }
        }

        private void dobtime_ValueChanged(object sender, EventArgs e)
        {
            int age = CalculateAge(dobtime.Value);
            if (age < 0 && age >= 10){
                invalidDatelb.Visible = true;
                agelb.Text = "0";
            }
            else
            {
                invalidDatelb.Visible = false;
                agelb.Text = age.ToString();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void aboutEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}