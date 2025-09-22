using App.UI_Forms.Manager;
using System;
using System.Collections;
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
    public partial class Payment : Form
    {
        string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        string txnId = null;
        private static int orderId;
        DataTable orderIdTable = new DataTable();
        public Payment()
        {
            InitializeComponent();

            pnlCardPay.Visible = false;
            pnlCashPay.Visible = true;
            pnlMobilePay.Visible = false;

        }

        public Payment(string totalPrice, string discount, string netAmount)
        {
            InitializeComponent();
            pnlCardPay.Visible = false;
            pnlCashPay.Visible = true;
            pnlMobilePay.Visible = false;
            //string detailQuery = @"
            //                        SELECT od.ProductID, pr.ProductName, od.Quantity, od.UnitPrice,
            //                               (od.Quantity * od.UnitPrice) AS SubTotal
            //                        FROM OrderDetails od
            //                        INNER JOIN Product pr ON od.ProductID = pr.ProductID
            //                        WHERE od.OrderID = " + orderId+"";

            ////dgvInvoice.DataSource = ExecuteQuery(detailQuery);
            ////orderIdTable = ExecuteQuery(detailQuery);

            //DataTable orderIdTable = ExecuteQuery(detailQuery);

            string detailQuery = @"
     SELECT od.ProductID, pr.ProductName, od.Quantity, od.UnitPrice,
            (od.Quantity * od.UnitPrice) AS SubTotal
     FROM OrderDetails od
     INNER JOIN Product pr ON od.ProductID = pr.ProductID
     WHERE od.OrderID = " + orderId;

            // Get DataTable from ExecuteQuery
            DataTable orderIdTable = ExecuteQuery(detailQuery);

            // ✅ Pass DataTable to InvoicePrinter
            


            txtTotalPrice_pay.Text = totalPrice.ToString();
            txtDiscount_pay.Text = discount.ToString();
            lblNetAmm_pay.Text = Math.Round(Convert.ToDecimal(netAmount), 0).ToString();

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

        public void CashPayment()
        {

            try {
                decimal netAmount = 0;
                decimal cashGiven = 0;

                if (!string.IsNullOrWhiteSpace(lblNetAmm_pay.Text))
                    netAmount = Convert.ToDecimal(lblNetAmm_pay.Text);

                if (!string.IsNullOrWhiteSpace(txtCashGiven.Text))
                    cashGiven = Convert.ToDecimal(txtCashGiven.Text);


                if (string.IsNullOrWhiteSpace(txtCashGiven.Text))
                {
                    txtCashGiven.Text = ".00";
                    return;
                }
                if (Convert.ToDecimal(txtCashGiven.Text) < Convert.ToDecimal(lblNetAmm_pay.Text))
                {
                    txtChangedAmnt.Clear();
                    return;
                }

                decimal changeAmmount = cashGiven - netAmount;
                changeAmmount = Math.Truncate(changeAmmount);
                txtChangedAmnt.Text = changeAmmount.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter valid Ammount.",
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

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbPaymentMethod.SelectedItem.ToString() == "Cash")
            {
                pnlCardPay.Visible = false;
                pnlCashPay.Visible = true;
                pnlMobilePay.Visible = false;
            }
             else if (cmbPaymentMethod.SelectedItem.ToString() == "Card")
            {
                pnlCardPay.Visible = true;
                pnlCashPay.Visible = false;
                pnlMobilePay.Visible = false;
            }
            else if (cmbPaymentMethod.SelectedItem.ToString() == "Mobile Payment")
            {
                pnlCardPay.Visible = false;
                pnlCashPay.Visible = false;
                pnlMobilePay.Visible = true;
            }

        }

        private void txtCashGiven_TextChanged(object sender, EventArgs e)
        {
            CashPayment();
        }

        private void txtChangedAmnt_TextChanged(object sender, EventArgs e)
        {
            CashPayment();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text.Length > 100)
            {
                MessageBox.Show("Name cannot exceed 50 charecter.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCusPhone.Text.Length > 11)
            {
                MessageBox.Show("Phone number cannot exceed 11 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string method = cmbPaymentMethod.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please select a payment method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal netAmount;
            if (!decimal.TryParse(lblNetAmm_pay.Text, out netAmount) || netAmount <= 0)
            {
                MessageBox.Show("Invalid Net Amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 🔹 Validate based on method
            if (method == "Cash")
            {
                decimal cashGiven;
                if (!decimal.TryParse(txtCashGiven.Text, out cashGiven) || cashGiven < netAmount)
                {
                    MessageBox.Show("Insufficient or invalid cash given.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txnId = "Cash";
            }
            else if (method == "Card")
            {
                if (string.IsNullOrWhiteSpace(txtCardNo.Text))
                {
                    MessageBox.Show("Please enter Card Reference Number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txnId = txtCardNo.Text.Trim();
            }
            else if (method == "Mobile Payment")
            {
                if (string.IsNullOrWhiteSpace(txtTxnID.Text))
                {
                    MessageBox.Show("Please enter Mobile Transaction ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txnId = txtTxnID.Text.Trim();
            }

            // 🔹 Save to Database
            try
            {
                SaveOrderAndPayment();
                ////this.Close();
                string query = "TRUNCATE TABLE CartView;";
                ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message,
                                "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SaveOrderAndPayment() 
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int customerId = 0;
                    string phoneValue = string.IsNullOrWhiteSpace(txtCusPhone.Text) ? "NULL" : txtCusPhone.Text.Trim();
                    //// 1️. Insert Customer
                    //string insertCustomerQuery = "INSERT INTO Customer (Name, Phone) VALUES ('" + txtCusName.Text.Trim() + "', "+phoneValue+");" + 
                    //                             "SELECT SCOPE_IDENTITY(); ";



                    //SqlCommand cmdCustomer = new SqlCommand(insertCustomerQuery, conn);

                    //int customerId = Convert.ToInt32(cmdCustomer.ExecuteScalar());



                    // 1️⃣ Check if customer already exists by phone
                    string checkCustomerQuery = "SELECT CustomerID FROM Customer WHERE Phone = " + phoneValue;
                    SqlCommand cmdCheck = new SqlCommand(checkCustomerQuery, conn);
                    object result = cmdCheck.ExecuteScalar();

                    if (result != null) // customer already exists
                    {
                        customerId = Convert.ToInt32(result);
                        if (!string.IsNullOrWhiteSpace(txtCusName.Text))
                        {
                            // Update name if provided
                            string updateCustomerNameQuery = "UPDATE Customer SET Name = '" + txtCusName.Text.Trim() + "' WHERE CustomerID = " + customerId;
                            ExecuteNonQuery(updateCustomerNameQuery);
                        }
                    }
                    else // insert new customer
                    {
                        string insertCustomerQuery = "INSERT INTO Customer (Name, Phone) VALUES ('" + txtCusName.Text.Trim() + "', '" + phoneValue + "');" +
                                                     "SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdCustomer = new SqlCommand(insertCustomerQuery, conn);
                        customerId = Convert.ToInt32(cmdCustomer.ExecuteScalar());

                    }

                    // 2️. Insert Order
                    string insertOrderQuery =
                    "INSERT INTO Orders (CustomerID, TotalAmount) VALUES (" + customerId + ", " + Convert.ToDecimal(lblNetAmm_pay.Text) + "); " +
                    "SELECT SCOPE_IDENTITY();";



                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn);
                    orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());

                    // 3. Insert Orderdetails from CartView
                    string insertDetailQuery = "INSERT INTO OrderDetails (OrderID, ProductName, ProductID, Quantity, UnitPrice)"+
                    "SELECT "+ orderId + ", ProductName, ProductID, Quantity, UnitPrice FROM CartView";
                    ExecuteNonQuery(insertDetailQuery);

                    string detailQuery = @"
                                        SELECT od.ProductID, pr.ProductName, od.Quantity, od.UnitPrice,
                                               (od.Quantity * od.UnitPrice) AS SubTotal
                                        FROM OrderDetails od
                                        INNER JOIN Product pr ON od.ProductID = pr.ProductID
                                        WHERE od.OrderID = "+orderId+"";

                    orderIdTable = ExecuteQuery(detailQuery);



                    // 4️. Insert Payment
                    string insertPaymentQuery = "INSERT INTO Payment (OrderID, PaymentMethod, Amount, TransactionID)"+
                          "VALUES ("+ orderId + ", '"+ cmbPaymentMethod.SelectedItem.ToString() + "', "+""+ Convert.ToDecimal(lblNetAmm_pay.Text) + ", '"+ txnId.ToString() + "')";
                    ExecuteNonQuery(insertPaymentQuery);


                    MessageBox.Show($"Payment successful. Order ID: {orderId}", 
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string updateStockQuery = "UPDATE Product SET Stock = Stock - (SELECT Quantity FROM CartView C WHERE C.ProductID = Product.ProductID)" +
                                                "WHERE ProductID IN (SELECT ProductID FROM CartView);";
                    ExecuteNonQuery(updateStockQuery);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCusPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCusPhone.Text))
                    Convert.ToInt32(txtCusPhone.Text);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric phone number.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you entered is too large.",
                                "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrintInvoice()
        {
            InvoicePrinter printer = new InvoicePrinter(orderId);

            printer.Print();
        }
        private void btnRecept_Click(object sender, EventArgs e)
        {
            if (orderId <= 0 || orderIdTable.Rows.Count == 0)
            {
                MessageBox.Show("No order found to print receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintInvoice();

        }
    }
}
