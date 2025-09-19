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
using System.Xml.Linq;

namespace App
{
    public partial class Cashier : Form
    {
        int serial = -1;
        string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        public Cashier()
        {
            InitializeComponent();
            show();
            CartView();
            clear();
            clearCart();
            LoadCategories();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
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
                MessageBox.Show("A database error occurred:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        private void show()
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string query = "select ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate from Product;";
            dgvProduct.DataSource = ExecuteQuery(query);
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            //DataTable dt2 = ds.Tables[1];
            dgvProduct.AutoGenerateColumns = true;
            //dgvProduct.DataSource = dt;
        }


        public void CartView()
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string query = "select * from CartView;";
            dgvCartView.DataSource = ExecuteQuery(query);
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dgvCartView.AutoGenerateColumns = true;
            //dgvCartView.DataSource = dt;
            totalPrice();
        }
        public void removeCart()
        {
            if (serial == -1)
            {
                MessageBox.Show("Please select a row first from Cart!");
                return;
            }

            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string query = "DELETE FROM CartView WHERE Serial = "+serial+"";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@Serial", serial);
            //cmd.ExecuteNonQuery();
            ExecuteNonQuery(query);

            //MessageBox.Show("Removed from Cart Successfully");
            CartView(); // refresh grid
            clear();    // clear input fields
            clearSearch();
            serial = -1; // reset selection
        }
        public void clearCart()
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string query = "DELETE FROM CartView; TRUNCATE TABLE CartView;";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.ExecuteNonQuery();
            ExecuteNonQuery(query);
            //MessageBox.Show("Removed from Cart Successfully");
            CartView();
            clear();
        }

        public void totalPrice()
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string query = "SELECT SUM(UnitPrice * Quantity) AS TotalPrice FROM CartView;";
            DataTable dt = ExecuteQuery(query);
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
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
                    txtDiscount.Text = "0";
                    discount = 0;
                }

                // Calculate net amount
                decimal netAmm = totalPrice - (discount / 100) * totalPrice;

                // Show result
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

        public void clear()
        {
            txtProductID.Clear();
            txtProName.Clear();
            txtCategory.Clear();
            txtUnitePrice.Clear();
            //txtSearch.Clear();
            nudQuantity.Value = 1;
        }
        public void clearSearch()
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        private void panleVisible()
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
            pnlCartView.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            panleVisible();
            pnlHome.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panleVisible();
            pnlProduct.Visible = true;
            pnlCartView.Visible = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panleVisible();
            pnlOrder.Visible = true;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            panleVisible();
            pnlFeedback.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panleVisible();
            pnlProfile.Visible = true;
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

        private void btnFeedback_MouseLeave(object sender, EventArgs e)
        {
            btnFeedback.BackColor = Color.FromArgb(255, 255, 255);
            btnFeedback.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnFeedback_MouseMove(object sender, MouseEventArgs e)
        {
            btnFeedback.BackColor = Color.FromArgb(25, 112, 255);
            btnFeedback.ForeColor = Color.FromArgb(255, 255, 255);
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

       

        //private void btnAdd_MouseLeave(object sender, EventArgs e)
        //{
        //    //btnAdd.BackColor = Color.FromArgb(100, 88, 255);
        //}

        //private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //btnAdd.BackColor = Color.FromArgb(7, 99, 102);
        //}

        //private void btnRemove_MouseLeave(object sender, EventArgs e)
        //{
        //    btnRemove.BackColor = Color.FromArgb(100, 88, 255);
        //}

        //private void btnRemove_MouseMove(object sender, MouseEventArgs e)
        //{
        //    btnRemove.BackColor = Color.FromArgb(7, 99, 102);
        //}

        //private void btnClear_MouseLeave(object sender, EventArgs e)
        //{
        //    btnClear.BackColor = Color.FromArgb(100, 88, 255);
        //}

        //private void btnClear_MouseMove(object sender, MouseEventArgs e)
        //{
        //    btnClear.BackColor = Color.FromArgb(7, 99, 102);
        //}

      
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
                txtProductID.Text = dgvCartView.Rows[e.RowIndex].Cells["ProductID"].Value.ToString().Trim();
                nudQuantity.Value = Convert.ToDecimal(dgvCartView.Rows[e.RowIndex].Cells["Quantity"].Value);
                serial = Convert.ToInt32(dgvCartView.Rows[e.RowIndex].Cells["Serial"].Value);
            }
            else { 
                MessageBox.Show("Please select a valid row!");
            }
        }

        // 
        // Add, Edit, Remove, Clear Button
        // 
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

                    string checkQuery = "SELECT Quantity, Serial FROM CartView WHERE ProductID = @ProductID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim());
                    SqlDataReader reader = checkCmd.ExecuteReader();
                    if (reader.Read()) // Product exists, update quantity
                    {
                        int existingQuantity = Convert.ToInt32(reader["Quantity"]);
                        int productSerial = Convert.ToInt32(reader["Serial"]);
                        reader.Close();

                        string updateQuery = "UPDATE CartView SET Quantity = " + (existingQuantity + Convert.ToInt32(nudQuantity.Value)) +
                         " WHERE Serial = " + productSerial + ";";
                        //string updateQuery = "UPDATE CartView SET Quantity = @Quantity WHERE Serial = @Serial";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        //updateCmd.Parameters.AddWithValue("@Quantity", existingQuantity + Convert.ToInt32(nudQuantity.Value));
                        //updateCmd.Parameters.AddWithValue("@Serial", productSerial);
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
            if (serial == -1)
            {
                MessageBox.Show("Please select a row first from Cart!");
                return;
            }

            else
            {
                //SqlConnection conn = new SqlConnection(connectionString);
                //conn.Open();
                //string query = "UPDATE CartView SET Quantity = 5 WHERE ProductID = 101;";
                string query = "UPDATE CartView SET Quantity = " + nudQuantity.Value + " WHERE Serial = " + serial + ";";
                //SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.ExecuteNonQuery();
                ExecuteNonQuery(query);
                CartView();
                clear();
                clearSearch();
                serial = -1;
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
                //SqlConnection conn = new SqlConnection(connectionString);
                //conn.Open();
                string query;

                if (cmbCategory.SelectedItem.ToString() == "All")
                {
                    query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate FROM Product;";
                }
                else
                {
                    //query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                    //        "FROM Product WHERE CateogoryName = @Category;";

                    query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                                "FROM Product WHERE CateogoryName = '" + cmbCategory.SelectedItem.ToString() + "'";
                }

            //DataTable dt = ExecuteQuery(query);

            //SqlCommand cmd = new SqlCommand(query, conn);

                //if (cmbCategory.SelectedItem.ToString() != "All")
                //{
                //    cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());
                //}

                //SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
            //adp.Fill(ds);

            //dgvProduct.DataSource = ds.Tables[0];
            dgvProduct.DataSource = ExecuteQuery(query);
            clear();
            txtSearch.Clear();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            //LoadCategories();
            //cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            totalPriceAfterDiscount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            string searchText = "%" + txtSearch.Text + "%";
            string query = "SELECT ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate " +
                           "FROM Product WHERE ProductName LIKE '"+searchText+ "' OR CateogoryName LIKE '"+searchText+ "' OR ProductID LIKE '"+searchText+"';";

            dgvProduct.DataSource = ExecuteQuery(query);
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //dgvProduct.DataSource = ds.Tables[0];
            clear();

        }

        private void lblNetAmm_TextChanged(object sender, EventArgs e)
        {
            //decimal netAmm = Convert.ToDecimal(txtTotalPrice.Text) - (Convert.ToDecimal(txtDiscount.Text)/100)*Convert.ToDecimal(txtTotalPrice.Text);
            totalPriceAfterDiscount();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //decimal netAmm = Convert.ToDecimal(txtTotalPrice.Text) - (Convert.ToDecimal(txtDiscount.Text) / 100) * Convert.ToDecimal(txtTotalPrice.Text);
            //lblNetAmm.Text = netAmm.ToString("0.00");

            totalPriceAfterDiscount();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.Clear();
        }
    }
}
