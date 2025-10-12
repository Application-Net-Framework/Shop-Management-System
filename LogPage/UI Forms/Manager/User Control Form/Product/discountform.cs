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
    public partial class discountform : UserControl
    {
        public string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        
        public string discountId;
        public string discountCode;
        public string discountPercentage;
        public DateTime startDate;
        public DateTime endDate;

        public discountform()
        {
            InitializeComponent();
            LoadDatabase();
        }
        
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                discountCode = discountcodetxt.Text;
                discountPercentage = percentagetxt.Text;
                startDate = startdate.Value;
                endDate = enddate.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Discounts (DiscountCode, Percentage, StartDate, EndDate, DiscountStatus) " +
                                         "VALUES (@DiscountCode, @Percentage, @StartDate, @EndDate, 'Active')";
                    
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DiscountCode", discountCode);
                        command.Parameters.AddWithValue("@Percentage", discountPercentage);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Discount code '{discountCode}' has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            LoadDatabase();
                            
                            discountIdtxt.Clear();
                            discountcodetxt.Clear();
                            percentagetxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No discount was added. Please try again.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void activebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(discountId))
                {
                    MessageBox.Show("Please select a discount from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Discounts SET DiscountStatus = 'Active' WHERE DiscountID = @DiscountID";
                    
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DiscountID", discountId);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Discount code '{discountCode}' has been activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data grid
                            LoadDatabase();
                            // Clear the selection
                            discountId = null;
                            discountCode = null;
                            discountIdtxt.Clear();
                            discountcodetxt.Clear();
                            percentagetxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No discount was updated. Please verify the discount ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error activating discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(discountId))
                {
                    MessageBox.Show("Please select a discount from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show($"Are you sure you want to delete discount '{discountCode}'?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                {
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Discounts WHERE DiscountID = @DiscountID";
                    
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DiscountID", discountId);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Discount code '{discountCode}' has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data grid
                            LoadDatabase();
                            // Clear the selection
                            discountId = null;
                            discountCode = null;
                            discountIdtxt.Clear();
                            discountcodetxt.Clear();
                            percentagetxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No discount was deleted. Please verify the discount ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deactivebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(discountId))
                {
                    MessageBox.Show("Please select a discount from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Discounts SET DiscountStatus = 'Inactive' WHERE DiscountID = @DiscountID";
                    
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DiscountID", discountId);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Discount code '{discountCode}' has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data grid
                            LoadDatabase();
                            // Clear the selection
                            discountId = null;
                            discountCode = null;
                            discountIdtxt.Clear();
                            discountcodetxt.Clear();
                            percentagetxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No discount was updated. Please verify the discount ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deactivating discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void LoadDatabase()
        {
            try
            {
                string inactiveEmployees = "SELECT * FROM Discounts";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);

                        if (discountDataTable != null)
                            discountDataTable.DataSource = dt2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discountDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = discountDataTable.Rows[e.RowIndex];
                
                // Store the selected discount's information
                discountId = row.Cells["DiscountID"].Value.ToString();
                discountCode = row.Cells["DiscountCode"].Value.ToString();
                
                discountIdtxt.Text = discountId;
                          
                if (row.Cells["Percentage"].Value != null)
                {
                    discountPercentage = row.Cells["Percentage"].Value.ToString();
                    
                    percentagetxt.Text = discountPercentage.ToString();
                }
                
                if (row.Cells["StartDate"].Value != DBNull.Value)
                {
                    startDate = Convert.ToDateTime(row.Cells["StartDate"].Value);
                    startdate.Value = startDate;
                }
                
                if (row.Cells["EndDate"].Value != DBNull.Value)
                {
                    endDate = Convert.ToDateTime(row.Cells["EndDate"].Value);
                    enddate.Value = endDate;
                }
            }
        }
    }
}
