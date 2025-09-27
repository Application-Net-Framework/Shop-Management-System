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
using App.Configuration; // Added reference to the namespace where GlobalConfig is defined

namespace App.UI_Forms.Admin.Features
{
    public partial class addProduct : UserControl
    {
        // Properties for storing product details
        public string ProductID, ProductName, Price, Category, Stock;
        
        // Connection string for database access
        private readonly string connectionString = GlobalConfig.ConnectionString;

        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the parent form that contains this UserControl
                Form parentForm = this.FindForm();
                
                // Check if we found the parent form and if it's the Admin_Main_Home type
                if (parentForm != null && parentForm is Admin.Admin_Main_Home)
                {
                    // Make this UserControl invisible
                    this.Visible = false;
                    
                    // Try to find and show the home1 control
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
                    else
                    {
                        MessageBox.Show("Could not find home page. Please navigate manually.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating back: " + ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate Product ID
            if (string.IsNullOrWhiteSpace(txtPID.Text))
            {
                MessageBox.Show("Product ID is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPID.Focus();
                return;
            }

            // Validate Product Name
            if (string.IsNullOrWhiteSpace(txtPName.Text))
            {
                MessageBox.Show("Product Name is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPName.Focus();
                return;
            }

            // Validate Price
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            // Check if price contains only numbers and decimal point
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            // Validate Category
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Category is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            // Validate Stock
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Stock quantity is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            // Check if stock contains only numbers
            if (!int.TryParse(txt.Text, out _))
            {
                MessageBox.Show("Stock must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            // Store values if all validations pass
            ProductID = txtPID.Text;
            ProductName = txtPName.Text;
            Price = txtPrice.Text;
            Category = txtPhoneNumber.Text;
            Stock = txt.Text;

            // Connect to database and add product
            if (AddProduct())
            {
                // Show success message
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form fields after successful addition
                ClearFields();
            }
        }

        // Method to add product to the database
        private bool AddProduct()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Use parameterized query to prevent SQL injection
                    // Updated column names to match the actual database schema
                    string query = "INSERT INTO Product (ProductID, ProductName, Price, CateogoryName, Stock) VALUES (@ProductID, @ProductName, @Price, @Category, @Stock)";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters with proper types
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@ProductName", ProductName);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(Price));
                        command.Parameters.AddWithValue("@Category", Category);
                        command.Parameters.AddWithValue("@Stock", int.Parse(Stock));
                        
                        command.ExecuteNonQuery();
                        return true; // Return true if successful
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if there was an error
            }
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPrice.Clear();
            txtPhoneNumber.Clear();
            txt.Clear();
        }
    }
}
