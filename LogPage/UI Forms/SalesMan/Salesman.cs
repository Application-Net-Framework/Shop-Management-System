using App.Configuration;
using App.Configuration;
using App.UI_Forms.Admin;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App
{
    public partial class Salesman : Form
    {
        private int employeeId;
        private string employeeName;
        String connectionString = GlobalConfig.ConnectionString;
        public Salesman()
        {
            InitializeComponent();
            
        }
        public Salesman(int userId, string userName)
        {
            InitializeComponent();
            employeeId = userId;
            employeeName = userName;
        }

      
        private void LoadLowStockProducts()
        {
            string query = @"SELECT ProductID, ProductName, Stock 
                           FROM Product 
                           WHERE Stock < 5";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lowStockGrid.DataSource = dt;
            if (dt.Rows.Count > 0) { MessageBox.Show("Some products are low in stock!", "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void LoadSupplierRequests()
        {
            string query = @"SELECT SR.RequestID, SR.ProductID, S.ProductName, SR.RequestedQuantity, SR.RequestDate
            FROM SupplierRequest SR
            INNER JOIN dbo.Product S ON SR.ProductID = S.ProductID
            ORDER BY SR.RequestDate DESC";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            supplierRequestGrid.DataSource = dt;
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman h = new Salesman(employeeId, employeeName);
            h.StartPosition = FormStartPosition.Manual;
            h.Location = this.Location;
            h.Size = this.Size;
            h.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Size = this.Size;
            login.Show();
            this.Close();
        }

        private void Cashier_Home_Load(object sender, EventArgs e)   
        {
            welcomeLabel.Text = "Welcome, " + employeeName;
            LoadLowStockProducts();
        }
        private void headerPnl_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {   Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }
        private void pQueryBtn_Click(object sender, EventArgs e)
        {   ProductQuery PQ = new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
            this.Hide();
        }

        private void cManagementBtn_Click(object sender, EventArgs e)
        {   CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }
        private void supplierRequestBtn_Click_1(object sender, EventArgs e)
        {
            if (lowStockGrid.Rows.Count < 2) { MessageBox.Show("No low-stock products to request.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return;}

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            foreach (DataGridViewRow row in lowStockGrid.Rows)
            {
                if (row.IsNewRow) continue;
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int requestedQty = 10 - currentQty;
                               
                string insertQuery = "INSERT INTO SupplierRequest (ProductID, RequestedQuantity) " +
                                     "VALUES (" + productId + ", " + requestedQty + ")";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
            }   MessageBox.Show("Supplier requests created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void supplyRequestBtn_Click(object sender, EventArgs e) { LoadSupplierRequests(); }
        private void preOrderBtn_Click(object sender, EventArgs e)
        {   PreOrder PO = new PreOrder();
            PO.StartPosition = FormStartPosition.Manual;
            PO.Location = this.Location;
            PO.Size = this.Size;
            PO.Show();
            this.Hide();
        }
    }
}
