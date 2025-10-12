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
    public partial class ucPnl_Order : UserControl
    {
        readonly string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True";
        //readonly string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        public ucPnl_Order()
        {
            InitializeComponent();
            LoadOrdersTable();
            dgvOrderDetails_order.Visible = false;
            lblProductDetails_order.Visible = false;
        }
        static int orderid = -1;
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



        public void LoadOrdersTable()
        {
            string query = "SELECT o.OrderID, o.OrderDate, o.TotalAmount, p.PaymentMethod, c.Phone, c.Name " +
                            "FROM Orders o " +
                            "INNER JOIN Payment p ON o.OrderID = p.OrderID " +
                            "INNER JOIN Customer c ON o.CustomerID = c.CustomerID;";
            dgvOrders_order.DataSource = ExecuteQuery(query);
            dgvOrders_order.AutoGenerateColumns = true;
        }

        public void RefreshData()
        {
            dgvOrderDetails_order.DataSource = null; // clear details grid
            dgvOrderDetails_order.Visible = false; // clear details grid
            lblProductDetails_order.Visible = false;
            lblOrderId.Visible = false;
            txtOrderId.Visible = false;
            txtSearch_order.Clear();
            orderid = -1;
        }


        private void dgvOrders_order_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // avoid header row
            {
                DataGridViewRow row = dgvOrders_order.Rows[e.RowIndex];


                //Order Details (products)
                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);

                string detailQuery = @"
                                    SELECT od.ProductID, pr.ProductName, od.Quantity, od.UnitPrice,
                                           (od.Quantity * od.UnitPrice) AS SubTotal
                                    FROM OrderDetails od
                                    INNER JOIN Product pr ON od.ProductID = pr.ProductID
                                    WHERE od.OrderID = " + orderId;

                dgvOrderDetails_order.DataSource = ExecuteQuery(detailQuery);
                dgvOrderDetails_order.Visible = true;
                lblProductDetails_order.Visible = true;
                orderid = orderId;
                txtOrderId.Text = " "+orderid.ToString()+ " ";
                lblOrderId.Visible = true;
                txtOrderId.Visible = true;
            }
            else
            {
                orderid = -1;
                dgvOrderDetails_order.DataSource = null; // Clear details if invalid row
                MessageBox.Show("Please select a valid row!");
            }
        }

        private void btnRefresh_order_Click_1(object sender, EventArgs e)
        {
            LoadOrdersTable();
            RefreshData();
        }

        private void txtSearch_order_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = "%" + txtSearch_order.Text + "%";

            string query = "SELECT o.OrderID, o.OrderDate, o.TotalAmount, p.PaymentMethod, c.Phone, c.Name " +
                            "FROM Orders o " +
                            "INNER JOIN Payment p ON o.OrderID = p.OrderID " +
                            "INNER JOIN Customer c ON o.CustomerID = c.CustomerID " +
                            "WHERE c.Phone LIKE '" + searchText + "' OR o.OrderID LIKE '" + searchText + "'";

            dgvOrders_order.DataSource = ExecuteQuery(query);

            dgvOrderDetails_order.Visible = false;
            lblProductDetails_order.Visible = false;
        }

        private void lblReceipt_home_Click(object sender, EventArgs e)
        {
            if (orderid == -1)
            {
                MessageBox.Show("Please select an order first from Order Details!");
                return;
            }
            InvoicePrinter printer = new InvoicePrinter(orderid);

            printer.Print();

            orderid = -1; // reset after printing
        }
    }
}
