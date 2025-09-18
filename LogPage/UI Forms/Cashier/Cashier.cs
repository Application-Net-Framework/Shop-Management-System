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
        public Cashier()
        {
            InitializeComponent();
            show();
            CartView();
            clear();
            clearCart();
        }
        private void show()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select ProductID, ProductName, CateogoryName, Stock, Price, Description, ExpiryDate from Product;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            //DataTable dt2 = ds.Tables[1];
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.DataSource = dt;
        }


        public void CartView()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from CartView;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            //DataTable dt2 = ds.Tables[1];
            dgvCartView.AutoGenerateColumns = true;
            dgvCartView.DataSource = dt;
            totalPrice();
        }
        public void removeCart()
        {
            if (serial == -1)
            {
                MessageBox.Show("Please select a row first from Cart!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM CartView WHERE Serial = @Serial";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Serial", serial);
                    cmd.ExecuteNonQuery();
                }
            }

            //MessageBox.Show("Removed from Cart Successfully");
            CartView(); // refresh grid
            clear();    // clear input fields
            serial = -1; // reset selection
        }
        public void clearCart()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "DELETE FROM CartView; TRUNCATE TABLE CartView;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Removed from Cart Successfully");
            CartView();
            clear();
        }

        public void totalPrice()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT SUM(UnitPrice * Quantity) AS TotalPrice FROM CartView;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalPrice"] != DBNull.Value)
            {
                txtTotalPrice.Text = dt.Rows[0]["TotalPrice"].ToString();
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        public void clear()
        {
            txtProductID.Clear();
            txtProName.Clear();
            txtCategory.Clear();
            txtUnitePrice.Clear();
            nudQuantity.Value = 1;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

            pnlHome.Visible = true;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = true;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = true;
            pnlFeedback.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = true;
            pnlProfile.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlProduct.Visible = false;
            pnlOrder.Visible = false;
            pnlFeedback.Visible = false;
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

        private void SalesMan_Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSMSdbDataSet_CashierProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.gSMSdbDataSet_CashierProduct.Product);

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(7, 99, 102);
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void btnRemove_MouseMove(object sender, MouseEventArgs e)
        {
            btnRemove.BackColor = Color.FromArgb(7, 99, 102);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void btnClear_MouseMove(object sender, MouseEventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(7, 99, 102);
        }

      
        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUnitePrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void dgvCartView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // avoid header row
            {
                txtProductID.Text = dgvCartView.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
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
            if(string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtProName.Text) || string.IsNullOrWhiteSpace(txtUnitePrice.Text))
            {
                MessageBox.Show("Please select a product first!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string checkQuery = "SELECT Quantity, Serial FROM CartView WHERE ProductID = @ProductID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
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

               
                //MessageBox.Show("Added to Cart Successfully");
                CartView();
                clear();
                totalPrice();
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
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //string query = "UPDATE CartView SET Quantity = 5 WHERE ProductID = 101;";
            string query = "UPDATE CartView SET Quantity = " + nudQuantity.Value + " WHERE Serial = " + serial + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            CartView();
        }
    }
}
