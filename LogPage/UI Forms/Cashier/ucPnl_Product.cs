using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Cashier
{
    public partial class ucPnl_Product : UserControl
    {
        int RowID = -1;
        static int orderid = -1;

        readonly string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        public ucPnl_Product()
        {
            InitializeComponent();
            show();
            CartView();
            clear();
            clearCart();
            LoadCategories();
            totalPriceAfterDiscount();

            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
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

                string cartQtyQuery = "SELECT ISNULL(SUM(Quantity),0) FROM CartView WHERE ProductID = " + txtProductID.Text.Trim() + "";
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

            string query = "DELETE FROM CartView WHERE RowID = " + RowID + "";
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

















    

        // 
        // Add, Edit, Remove, Clear Button
        // 


        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txtProName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            txtCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            txtUnitePrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
        }

        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        
        }

        private void dgvCartView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
            else
            {
                MessageBox.Show("Please select a valid row!");
            }
        }

        private void dgvCartView_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            show();
            clear();
            clearSearch();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
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

                    string checkQuery = "SELECT Quantity, RowID FROM CartView WHERE ProductID = " + txtProductID.Text.Trim() + "";
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
        private void txtTotalPrice_TextChanged_1(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = "%" + txtSearch.Text + "%";
            string query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                           "FROM Product WHERE ProductName LIKE '" + searchText + "' OR CateogoryName LIKE '" + searchText + "' OR ProductID LIKE '" + searchText + "';";

            dgvProduct.DataSource = ExecuteQuery(query);
            clear();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void lblNetAmm_Click(object sender, EventArgs e)
        {

        }

        private void lblNetAmm_TextChanged(object sender, EventArgs e)
        {
            totalPriceAfterDiscount();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
        }

        private void btnPay_Click(object sender, EventArgs e)
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

        private void ucPnl_Product_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(952, 602);
            totalPriceAfterDiscount();
        }
    }
}
