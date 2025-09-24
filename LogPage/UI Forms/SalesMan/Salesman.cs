using App.UI_Forms.SalesMan;
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
    public partial class Salesman : Form
    {

        String connectionString = @"Data Source=DESKTOP-ESC3M7E\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Salesman()
    {       InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi; 
            this.AutoSize = true;
    }

        private void LoadLowStockProducts()
        {
            string query = @"SELECT ProductID, ProductName, Quantity 
                           FROM Stock 
                           WHERE Quantity < 5";
            //here Table name: Stock
            SqlConnection con = new SqlConnection(connectionString);            
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lowStockGrid.DataSource = dt; 
            if (dt.Rows.Count > 0) { MessageBox.Show("⚠ Some products are low in stock!","Low Stock Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
        }






        private void LoadSupplierRequests()
        {
            string query = @"SELECT SR.RequestID, SR.ProductID, S.ProductName, SR.RequestedQuantity, SR.RequestDate
                 FROM SupplierRequest SR
                 INNER JOIN dbo.Stock S ON SR.ProductID = S.ProductID
                 ORDER BY SR.RequestDate DESC";

            SqlConnection con = new SqlConnection(connectionString);
            
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                supplierRequestGrid.DataSource = dt;

              
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman h = new Salesman();  
            h.Show();
            this.Hide();
        }    
                
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.Show();           
            this.Close();  
        }

        private void Cashier_Home_Load(object sender, EventArgs e)
        {
            LoadLowStockProducts();
        }       

        private void headerPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }

        private void pQueryBtn_Click(object sender, EventArgs e)
        {
            ProductQuery PQ=new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
            this.Hide();
        }

        private void cManagementBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement  CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }

        private void supplierRequestBtn_Click_1(object sender, EventArgs e)
        {
            if (lowStockGrid.Rows.Count <2)
            {
                MessageBox.Show("No low-stock products to request.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in lowStockGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);

                    // You can decide requested quantity (e.g., to restock to 10)
                    int requestedQty = 10 - currentQty;

                    string insertQuery = @"INSERT INTO SupplierRequest (ProductID, RequestedQuantity) 
                                   VALUES (@ProductID, @RequestedQuantity)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@RequestedQuantity", requestedQty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Supplier requests created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void supplyRequestBtn_Click(object sender, EventArgs e)
        {
            LoadSupplierRequests();
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {

            DiscountSuggestion DS = new DiscountSuggestion();
            DS.StartPosition = FormStartPosition.Manual;
            DS.Location = this.Location;
            DS.Size = this.Size;
            DS.Show();
            this.Hide();
        }
    }
}
