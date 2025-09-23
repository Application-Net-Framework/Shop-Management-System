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

namespace App.UI_Forms.Cashier
{
    public partial class ucPnl_Home : UserControl
    {
        static int orderid = -1;
        readonly string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        public ucPnl_Home()
        {
            InitializeComponent();
            LoadDashboardCards();
        }
        private DataTable ExecuteQuery(string query)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A database error occurred:" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void LoadDashboardCards()
        {
            try
            {
                // 1. Total Orders Today
                string ordersQuery = "SELECT COUNT(*) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                DataTable dtOrders = ExecuteQuery(ordersQuery);
                lblOrdersToday_home.Text = dtOrders.Rows[0][0].ToString();

                // 2. Revenue Today
                string revenueQuery = "SELECT ISNULL(SUM(TotalAmount),0) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                DataTable dtRevenue = ExecuteQuery(revenueQuery);
                lblRevenueToday_home.Text = Convert.ToDecimal(dtRevenue.Rows[0][0]).ToString("0.00");

                // 3. Low Stock
                string stockQuery = "SELECT COUNT(*) FROM Product WHERE Stock < 10";
                DataTable dtStock = ExecuteQuery(stockQuery);
                lblLowStock_home.Text = dtStock.Rows[0][0].ToString();

                // 4. New Customers Today
                string custQuery = "SELECT COUNT(*) FROM Customer WHERE CAST(JoinDate AS DATE) = CAST(GETDATE() AS DATE)";
                DataTable dtCust = ExecuteQuery(custQuery);
                lblNewCustomers_home.Text = dtCust.Rows[0][0].ToString();



                string recentOrdersQuery = @"
                    SELECT TOP 10 o.OrderID, o.OrderDate, c.Name AS CustomerName, c.Phone, o.TotalAmount
                    FROM Orders o
                    INNER JOIN Customer c ON o.CustomerID = c.CustomerID
                    ORDER BY o.OrderDate DESC";
                dgvRecentOrders_home.DataSource = ExecuteQuery(recentOrdersQuery);

                LoadMonthlySales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void LoadMonthlySales()
        {
            string query = @"
                            SELECT FORMAT(OrderDate,'MMM-yyyy') AS Month, SUM(TotalAmount) AS Revenue
                            FROM Orders
                            GROUP BY FORMAT(OrderDate,'MMM-yyyy')
                            ORDER BY MIN(OrderDate);";
            dgvMonthlySale_home.DataSource = ExecuteQuery(query);

            string topRecentMonthProductsQuery = @"
                                SELECT TOP 5 pr.ProductName, SUM(od.Quantity) AS TotalSold
                                FROM OrderDetails od
                                INNER JOIN Product pr ON od.ProductID = pr.ProductID
                                INNER JOIN Orders o ON od.OrderID = o.OrderID
                                WHERE o.OrderDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
                                GROUP BY pr.ProductName
                                ORDER BY TotalSold DESC;";
            dgvTopProduct_home.DataSource = ExecuteQuery(topRecentMonthProductsQuery);
        }

        private void btnReceipt_home_Click_1(object sender, EventArgs e)
        {

            if (orderid == -1)
            {
                MessageBox.Show("Please select an order first from Recent Orders!");
                return;
            }
            InvoicePrinter printer = new InvoicePrinter(orderid);

            printer.Print();

            orderid = -1; // reset after printing
        }

        private void pnlLowStock_home_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                string query = "SELECT ProductName, Stock FROM Product WHERE Stock < 10";
                DataTable dt = ExecuteQuery(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("All products are sufficiently stocked.");
                    return;
                }

                string items = "";
                foreach (DataRow row in dt.Rows)
                {
                    items += row["ProductName"] + " - Stock: " + row["Stock"] + "\n";
                }


                MessageBox.Show("Low Stock Products:\n\n" + items,
                                "Low Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching low stock items: " + ex.Message);
            }
        }

        private void dgvRecentOrders_home_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderid = -1;
            if (e.RowIndex >= 0) // avoid header row
            {
                DataGridViewRow row = dgvRecentOrders_home.Rows[e.RowIndex];
                orderid = Convert.ToInt32(row.Cells["OrderID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a valid row!");
                return;
            }
        }
    }
}
