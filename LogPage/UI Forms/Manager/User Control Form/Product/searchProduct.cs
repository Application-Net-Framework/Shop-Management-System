using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class searchProduct : UserControl
    {
        public string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        private int selectedProductId = -1;

        public searchProduct()
        {
            InitializeComponent();
            loadDatabase();
        }

        public void loadDatabase()
        {
            try
            {
                string query = "SELECT * FROM Product";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter sda2 = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);

                        if (productSearch != null)
                            productSearch.DataSource = dt2;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (productSearch.SelectedRows.Count > 0)
            {
             
                DataGridViewRow selectedRow = productSearch.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

              
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?", 
                    "Confirm Delete", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteProduct(productId);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Product WHERE ProductID = @ProductId";
                    
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            loadDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(productSearchBox.Text);
        }

        private void SearchProducts(string searchText)
        {
            try
            {
                // If search box is empty, reload all products
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    loadDatabase();
                    return;
                }

                // Match the correct column names from the Product table
                string searchQuery = "SELECT * FROM Product WHERE ProductName LIKE @SearchText OR CategoryName LIKE @SearchText OR Description LIKE @SearchText";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        
                        productSearch.DataSource = dt;
                        // Do NOT call loadDatabase() here as it would override search results
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Search error: " + ex.Message);
                MessageBox.Show("Error while searching: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productSearch.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
            }
        }
    }
}
