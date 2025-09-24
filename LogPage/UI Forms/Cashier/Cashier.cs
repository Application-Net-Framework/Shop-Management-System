
using App.UI_Forms.Admin;
using App.UI_Forms.Cashier;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace App
{
    public partial class mainCashier : Form
    {
        int RowID = -1;
        static int orderid = -1;
        readonly string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        public mainCashier()
        {
            InitializeComponent();
            PanleVisible();
            show();
            CartView();
            clear();
            clearCart();
            LoadCategories();
            LoadDashboardCards();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            //pnlHome.Visible = true;
            ucPnl_Home1.Visible = true;
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
        public int GetAvailableStock(string productId) //Product Panel
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string stockQuery = "SELECT Stock FROM Product WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(stockQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    object stockObj = cmd.ExecuteScalar();
                    if (stockObj == null || stockObj == DBNull.Value)
                    {
                        return -1; // product not found
                    }

                    return Convert.ToInt32(stockObj);
                }
            }
            catch
            {
                return -1; // error case
            }
        }


        public bool CheckAvailableStock() // check stock before adding to cart. // Product Panel
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please select a product first!");
                return false;
            }

            int availableStock = GetAvailableStock(txtProductID.Text.Trim());
            if (availableStock == -1)
            {
                MessageBox.Show("Product not found in database!");
                return false;
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string cartQtyQuery = "SELECT ISNULL(SUM(Quantity),0) FROM CartView WHERE ProductID = "+ txtProductID.Text.Trim() + "";
                SqlCommand cmd = new SqlCommand(cartQtyQuery, conn);

                int existingCartQty = Convert.ToInt32(cmd.ExecuteScalar());

                int requestedQty = existingCartQty + Convert.ToInt32(nudQuantity.Value);

                if (requestedQty > availableStock)
                {
                    MessageBox.Show($"Not enough stock! Available: {availableStock}, Requested: {requestedQty}",
                                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true; // ✅ Stock OK
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking stock: " + ex.Message);
                return false;
            }
        }


        private void show() // refresh product list grid
        {
            string query = "select ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate from Product;";
            dgvProduct.DataSource = ExecuteQuery(query);
            dgvProduct.AutoGenerateColumns = true;
        }


        public void CartView() // refresh cart grid
        {
            string query = "select ProductID, ProductName, Quantity, UnitPrice, RowID from CartView;";
            dgvCartView.DataSource = ExecuteQuery(query);
            dgvCartView.AutoGenerateColumns = true;
            totalPrice();
        }
        public void removeCart()
        {
            if (RowID == -1)
            {
                MessageBox.Show("Please select a row first from Cart!");
                return;
            }

            string query = "DELETE FROM CartView WHERE RowID = "+RowID+"";
            ExecuteNonQuery(query);

            //MessageBox.Show("Removed from Cart Successfully");
            CartView(); // refresh grid
            clear();    // clear input fields
            clearSearch();
            RowID = -1; // reset selection
        }
        public void clearCart() // clear CartView table
        {
            string query = "TRUNCATE TABLE CartView;";
            ExecuteNonQuery(query);
            CartView();
            clear();
        }

        public void totalPrice()
        {
            string query = "SELECT SUM(UnitPrice * Quantity) AS TotalPrice FROM CartView;";
            DataTable dt = ExecuteQuery(query);
            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalPrice"] != DBNull.Value)
            {
                txtTotalPrice.Text = dt.Rows[0]["TotalPrice"].ToString();
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }
        public void totalPriceAfterDiscount()
        {
            try
            {
                // Default values in case textboxes are empty
                decimal totalPrice = 0;
                decimal discount = 0;

                if (!string.IsNullOrWhiteSpace(txtTotalPrice.Text))
                    totalPrice = Convert.ToDecimal(txtTotalPrice.Text);

                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                    discount = Convert.ToDecimal(txtDiscount.Text);
                if (discount > 100) 
                {
                    MessageBox.Show("Discount cannot be greater than 100%.", 
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Clear();
                    discount = 0;
                }
                decimal netAmm = totalPrice - (discount / 100) * totalPrice;

                lblNetAmm.Text = netAmm.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Discount.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you entered is too large.",
                                "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clear() // clear input fields
        {
            txtProductID.Clear();
            txtProName.Clear();
            txtCategory.Clear();
            txtUnitePrice.Clear();
            nudQuantity.Value = 1;
        }
        public void clearSearch()
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
        }


        private void PanleVisible()
        {
            // Reset panel positions
            //pnlHome.Location = new Point(245, 46);
            ucPnl_Order1.Location = new Point(245, 46);
            pnlProduct.Location = new Point(245, 46);
            //pnlOrders.Location = new Point(245, 46);
            ucPnl_Home1.Location = new Point(245, 46);
            pnlProfile.Location = new Point(245, 46);

            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrders.Visible = false;
            pnlProfile.Visible = false;
            pnlCartView.Visible = false;
            ucPnl_Home1.Visible = false;
            ucPnl_Order1.Visible = false;
            ucPnl_Product1.Visible = false;

            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void ShowPanel(string panelName)
        {
            switch (panelName)
            {
                case "Home":
                    lblWelcome.Location = new Point(361, 5);
                    pnlWelcome.Size = new Size(904, 32);
                    this.ClientSize = new Size(952, 602);

                    PanleVisible();
                    LoadDashboardCards();
                    //pnlHome.Visible = true;
                    ucPnl_Home1.Visible = true;
                    break;

                case "Product":
                    lblWelcome.Location = new Point(481, 5);
                    pnlWelcome.Size = new Size(1140, 32);
                    this.ClientSize = new Size(1183, 602);

                    PanleVisible();
                    //pnlProduct.Visible = true;
                    //pnlCartView.Visible = true;
                    ucPnl_Product1.Visible = true;
                    //ucPnl_Product1.Location = new Point(245, 46);
                    //pnlProduct.Location = new Point(245, 46);
                    //pnlCartView.Location = new Point(830, 46);
                    break;

                case "Orders":
                    lblWelcome.Location = new Point(361, 5);
                    pnlWelcome.Size = new Size(904, 32);
                    this.ClientSize = new Size(952, 602);

                    PanleVisible();
                    //pnlOrders.Visible = true;
                    ucPnl_Order1.Visible = true;
                    LoadOrdersTable();
                    dgvOrderDetails_order.Visible = false;
                    lblProductDetails_order.Visible = false;
                    break;

                case "Profile":
                    lblWelcome.Location = new Point(361, 5);
                    pnlWelcome.Size = new Size(904, 32);
                    this.ClientSize = new Size(952, 602);
                    PanleVisible();
                    //ucPnl_Home.Visible = true;
                    //ucPnl_Home.BringToFront();
                    pnlProfile.Visible = false;


                    LoadOrdersTable();
                    pnlOrders.Visible = false;
                    ucPnl_Home1.Visible = true;
                    ucPnl_Order1.Visible= true;
                    break;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanel("Home");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowPanel("Product");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowPanel("Orders");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowPanel("Profile");
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(25, 112, 255);
            btnProduct.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(255, 255, 255);
            btnProduct.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(255, 255, 255);
            btnHome.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(25, 112, 255);
            btnHome.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(255, 255, 255);
            btnOrder.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(25, 112, 255);
            btnOrder.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(255, 255, 255);
            btnProfile.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnProfile_MouseMove(object sender, MouseEventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(25, 112, 255);
            btnProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }


        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txtProName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            txtCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            txtUnitePrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
        }
        private void dgvCartView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            clear();
            clearSearch();
            if (e.RowIndex >= 0) // avoid header row
            {
                txtProName.Text = dgvCartView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString().Trim();
                txtUnitePrice.Text = dgvCartView.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString().Trim();
                txtCategory.ReadOnly = true; // Category not in CartView
                txtProductID.Text = dgvCartView.Rows[e.RowIndex].Cells["ProductID"].Value.ToString().Trim();
                nudQuantity.Value = Convert.ToDecimal(dgvCartView.Rows[e.RowIndex].Cells["Quantity"].Value);
                RowID = Convert.ToInt32(dgvCartView.Rows[e.RowIndex].Cells["RowID"].Value);
            }
            else { 
                MessageBox.Show("Please select a valid row!");
            }
        }

        // 
        // Add, Edit, Remove, Clear Button
        // 

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            show();
            clear();
            clearSearch();

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please select a product first!");
                return;

            }

            else if (string.IsNullOrWhiteSpace(txtProName.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtUnitePrice.Text) || !decimal.TryParse(txtUnitePrice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Please enter a valid positive number for Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try 
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    if (!CheckAvailableStock())
                    {
                        return; // Stop if stock check fails
                    } 

                    string checkQuery = "SELECT Quantity, RowID FROM CartView WHERE ProductID = "+ txtProductID.Text.Trim() + "";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    SqlDataReader reader = checkCmd.ExecuteReader();
                    if (reader.Read()) // Product exists, update quantity
                    {
                        int existingQuantity = Convert.ToInt32(reader["Quantity"]);
                        int productSerial = Convert.ToInt32(reader["RowID"]);
                        reader.Close();

                        string updateQuery = "UPDATE CartView SET Quantity = " + (existingQuantity + Convert.ToInt32(nudQuantity.Value)) +
                         " WHERE RowID = " + productSerial + ";";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.ExecuteNonQuery();
                    }

                    else
                    {
                        reader.Close();
                        string query = "INSERT INTO CartView (ProductID, ProductName, UnitPrice, Quantity) " +
                      "VALUES (" + txtProductID.Text + ", '" + txtProName.Text + "', " + txtUnitePrice.Text + ", " + nudQuantity.Value + ")";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid numbers for ProductID, UnitPrice, and Quantity.\n" + ex.Message);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error occurred.\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\n" + ex.Message);
                }
                finally
                {
                    // Refresh cart and clear fields regardless of success/failure
                    CartView();
                    clear();
                    totalPrice();
                    clearSearch();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeCart();
            totalPrice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCart();
            clearSearch();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int availableStock = GetAvailableStock(txtProductID.Text.Trim());


            if (RowID == -1)
            {
                MessageBox.Show("Please select a row first from Cart!");
                return;
            }

            else if (availableStock == -1)
            {
                MessageBox.Show("Product not found!");
                return;
            }

            if (nudQuantity.Value > availableStock)
            {
                MessageBox.Show($"Not enough stock! Available: {availableStock}, Requested: {nudQuantity.Value}",
                                "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string query = "UPDATE CartView SET Quantity = " + nudQuantity.Value + " WHERE RowID = " + RowID + ";";
                ExecuteNonQuery(query);
                CartView();
                clear();
                clearSearch();
                RowID = -1;

                }

        }
        private void LoadCategories()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT DISTINCT CateogoryName FROM Product;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All"); // optional: show all products

            while (reader.Read())
            {
                cmbCategory.Items.Add(reader["CateogoryName"].ToString());
            }

            reader.Close();
            

            cmbCategory.SelectedIndex = 0; // default to "All"
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
                string query;

                if (cmbCategory.SelectedItem.ToString() == "All")
                {
                    query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate FROM Product;";
                }
                else
                {
                    query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                                "FROM Product WHERE CateogoryName = '" + cmbCategory.SelectedItem.ToString() + "'";
                }

            dgvProduct.DataSource = ExecuteQuery(query);
            clear();
            txtSearch.Clear();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(952, 602);
            totalPriceAfterDiscount();
            lblTimer.Text = DateTime.Now.ToString("dddd, MMM dd yyyy HH:mm:ss");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = "%" + txtSearch.Text + "%";
            string query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                           "FROM Product WHERE ProductName LIKE '"+searchText+ "' OR CateogoryName LIKE '"+searchText+ "' OR ProductID LIKE '"+searchText+"';";

            dgvProduct.DataSource = ExecuteQuery(query);
            clear();

        }

        private void lblNetAmm_TextChanged(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
            //txtDiscount.Clear();

        }
        private void dgvCartView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCartView.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString(); // start from 1
                e.Graphics.DrawString(rowNumber,
                    e.InheritedRowStyle.Font,
                    b,
                    e.RowBounds.Location.X + 10, // adjust left padding
                    e.RowBounds.Location.Y + 4); // adjust top padding
            }
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTotalPrice.Text) <= 0)
            {
                MessageBox.Show("Net Amount must be greater than zero to proceed with payment.",
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }

            string totalPrice = txtTotalPrice.Text;
            string discount = txtDiscount.Text;
            string netAmount = lblNetAmm.Text;

            clear();
            Payment paymentForm = new Payment(totalPrice, discount, netAmount);
            paymentForm.ShowDialog();
            show();
            CartView();
        }



        //
        //Order Panel
        //


        public void LoadOrdersTable()
        { 
            string query = "SELECT o.OrderID, o.OrderDate, o.TotalAmount, p.PaymentMethod, c.Phone, c.Name " +
                            "FROM Orders o " +
                            "INNER JOIN Payment p ON o.OrderID = p.OrderID " +
                            "INNER JOIN Customer c ON o.CustomerID = c.CustomerID;";
            dgvOrders_order.DataSource = ExecuteQuery(query);
            dgvOrders_order.AutoGenerateColumns = true;
        }

        private void txtSearch_order_TextChanged(object sender, EventArgs e)
        {
            string searchText = "%" + txtSearch_order.Text + "%";

            string query = "SELECT o.OrderID, o.OrderDate, o.TotalAmount, p.PaymentMethod, c.Phone, c.Name " +
                            "FROM Orders o " +
                            "INNER JOIN Payment p ON o.OrderID = p.OrderID " +
                            "INNER JOIN Customer c ON o.CustomerID = c.CustomerID " +
                            "WHERE c.Phone LIKE '" + searchText + "' OR o.OrderID LIKE '"+searchText+"'";

            dgvOrders_order.DataSource = ExecuteQuery(query);

            dgvOrderDetails_order.Visible = false;
            lblProductDetails_order.Visible = false;
        }

        private void dgvOrders_order_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // avoid header row
            {
                DataGridViewRow row = dgvOrders_order.Rows[e.RowIndex];

                // ------- Order Header directly from dgvOrders -------
                lblCustomerName_order.Text = row.Cells["Phone"].Value.ToString();
                lblOrderDate_order.Text = Convert.ToDateTime(row.Cells["OrderDate"].Value).ToString("dd-MMM-yyyy");
                lblTotal_order.Text = row.Cells["TotalAmount"].Value.ToString();
                lblPaymentMethod_order.Text = row.Cells["PaymentMethod"].Value.ToString();

                // ------- Order Details (products) -------
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
            }
            else
            {
                orderid = -1;
                dgvOrderDetails_order.DataSource = null; // Clear details if invalid row
                MessageBox.Show("Please select a valid row!");
            }
        }

        private void btnRefresh_order_Click(object sender, EventArgs e)
        {
            LoadOrdersTable();
            dgvOrderDetails_order.DataSource = null; // clear details grid
            dgvOrderDetails_order.Visible = false; // clear details grid
            lblProductDetails_order.Visible = false;
            txtSearch_order.Clear();
            orderid = -1;
        }

        private void pnlReceipt_home_Click(object sender, EventArgs e)
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

        //
        //Home Panel
        //


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


        private void btnReceipt_home_Click(object sender, EventArgs e)
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

        private void dgvRecentOrders_home_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void pnlLowStock_home_MouseClick(object sender, MouseEventArgs e)
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

        private void dgvProduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

    }
}
