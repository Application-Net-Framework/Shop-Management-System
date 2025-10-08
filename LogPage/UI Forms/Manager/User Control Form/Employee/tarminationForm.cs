using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class tarminationForm : UserControl
    {
        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public int selectedUserId = 0;
        public string selectedUserName = "";
        
        public void tarminationUI()
        {

        }
        public tarminationForm()
        {
            InitializeComponent();
            LoadDatabase();
            warningMassage.Visible = true;

            notFoundlb.Visible = false;
            adminPermission.Visible = false;

            deginepnl.Visible = false;
        }

        private void tarminationbtn_Click(object sender, EventArgs e)
        {

        }
        
        public void LoadDatabase()
        {
            try
            {
                string inactiveEmployees = "SELECT * FROM Employee WHERE AccountStatus = 'deactive'";
                    
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
  
                        if(TarminationEmployee != null)
                            TarminationEmployee.DataSource = dt2;
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void undobtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId <= 0)
                {
                    
                    return;
                }

                // Confirm reactivation
                DialogResult result = MessageBox.Show($"Are you sure you want to reactivate employee '{selectedUserName}'?\n\nThis will change their account status back to active.", 
                    "Confirm Reactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Change account status from deactive to active
                        string query = "UPDATE Employee SET AccountStatus = 'active' WHERE userID = @userID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userID", selectedUserId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Employee '{selectedUserName}' reactivated successfully! Account status changed to active.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                // Clear selection
                                selectedUserId = 0;
                                selectedUserName = "";
                                
                                // Refresh the grid to remove reactivated employee from terminated list
                                LoadDatabase();
                            }
                            else
                            {
                                MessageBox.Show("Employee not found or already active.", "Reactivation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reactivating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TarminationEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle selection of terminated employee for reactivation
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = TarminationEmployee.Rows[e.RowIndex];
                    
                    selectedUserId = Convert.ToInt32(row.Cells["userID"].Value);
                    selectedUserName = row.Cells["UserName"].Value?.ToString() ?? "";
                    
                    // Optional: Show selection feedback
                    MessageBox.Show($"Selected employee: {selectedUserName} (ID: {selectedUserId})\nClick 'Undo' to reactivate this employee.", "Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting employee: " + ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tarminationpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }
    }
}
