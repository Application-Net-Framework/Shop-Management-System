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
using App.Configuration; 

namespace App.UI_Forms.Admin.Features
{
    public partial class addProduct : UserControl
    {
        
        public string ProductName, Price, CategoryName, Stock;
        
        
        private readonly string connectionString = GlobalConfig.ConnectionString;

        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
               
                Form parentForm = this.FindForm();
                
                
                if (parentForm != null && parentForm is Admin.Admin_Main_Home)
                {
                    
                    this.Visible = false;
                    
                    
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
            
            if (string.IsNullOrWhiteSpace(txtPName.Text))
            {
                MessageBox.Show("Product Name is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPName.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

           
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Category is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Stock quantity is required.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            if (!int.TryParse(txt.Text, out _))
            {
                MessageBox.Show("Stock must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            
            
            ProductName = txtPName.Text;
            Price = txtPrice.Text;
            CategoryName = txtPhoneNumber.Text;
            Stock = txt.Text;

            
            if (AddProduct())
            {
                
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
                ClearFields();
            }
        }

        
        private bool AddProduct()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    
                    string query = "INSERT INTO Product (ProductName, Price, CategoryName, Stock) VALUES (@ProductName, @Price, @CategoryName, @Stock)";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        
                        command.Parameters.AddWithValue("@ProductName", ProductName);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(Price));
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@Stock", int.Parse(Stock));
                        
                        command.ExecuteNonQuery();
                        return true; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        
        private void ClearFields()
        {
           
            txtPName.Clear();
            txtPrice.Clear();
            txtPhoneNumber.Clear();
            txt.Clear();
        }
    }
}
