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

namespace App.UI_Forms.SalesMan
{
    public partial class ProductQuery : Form
    {
        String connectionString = @"Data Source=DESKTOP-ESC3M7E\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public ProductQuery()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;   // or AutoScaleMode.Font
            this.AutoSize = true;
        }
        private void SearchStockByName(string productName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT ProductID, ProductName, Category, PurchasePrice, 
                                            SellingPrice, Quantity, Unit, ExpiryDate
                                     FROM Stock
                                     WHERE ProductName LIKE @ProductName";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@ProductName", "%" + productName + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // show results in gridview
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT ProductID, ProductName, Category, PurchasePrice, 
                                            SellingPrice, Quantity, Unit, ExpiryDate, DateAdded, Description
                                     FROM Stock";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // bind result to gridview
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ProductQuery_Load(object sender, EventArgs e)
        {
            
        }

        private void pQueryBtn_Click(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman S = new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
            this.Hide();
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

        private void cManagementBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }

        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            PreOrder PO = new PreOrder();
            PO.StartPosition = FormStartPosition.Manual;
            PO.Location = this.Location;
            PO.Size = this.Size;
            PO.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchStockByName(nameTxt.Text);
;        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
    }
}
