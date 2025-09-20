using App.UI_Forms.Manager;
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
    public partial class Payment : Form
    {
        string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        string txnId = null;
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
           
            

            txtTotalPrice_pay.Text = totalPrice.ToString();
            txtDiscount_pay.Text = discount.ToString();
            lblNetAmm_pay.Text = Math.Round(Convert.ToDecimal(netAmount), 0).ToString();

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
                    //MessageBox.Show("Insufficient Cash Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



            //if (Convert.ToDecimal(txtCashGiven.Text) < Convert.ToDecimal(lblNetAmm_pay.Text))
            //{
            //    //MessageBox.Show("Insufficient Cash Given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else
            //{
            //    decimal changeAmmount = Convert.ToDecimal(txtCashGiven.Text) - Convert.ToDecimal(lblNetAmm_pay.Text);
            //    txtChangedAmnt.Text = changeAmmount.ToString("0.00");
            //}
            ////decimal changeAmmount = Convert.ToDecimal(txtCashGiven.Text) - Convert.ToDecimal(lblNetAmm_pay.Text);
            ////txtChangedAmnt.Text = changeAmmount.ToString("0.00");
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
            //if (string.IsNullOrWhiteSpace(txtCashGiven.Text))
            //{
            //    txtCashGiven.Text = ".00";
            //    return;
            //}
            CashPayment();
        }

        private void txtChangedAmnt_TextChanged(object sender, EventArgs e)
        {
            CashPayment();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }







        private int SaveOrderAndPayment(SqlConnection conn, SqlTransaction tran, string method, decimal netAmount, string txnId)
        {
            // 1. Insert into Orders
            string orderQuery = "INSERT INTO Orders (OrderDate, TotalAmount) " +
                        "OUTPUT INSERTED.OrderID " +
                        "VALUES (@OrderDate, @TotalAmount)";
            SqlCommand orderCmd = new SqlCommand(orderQuery, conn, tran);
            orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
            orderCmd.Parameters.AddWithValue("@TotalAmount", netAmount);

            int orderId = (int)orderCmd.ExecuteScalar();

            // 2. Insert into OrderDetails (from CartView)
            string detailsQuery = @"INSERT INTO OrderDetails (OrderID, ProductID, ProductName, UnitPrice, Quantity)
                            SELECT @OrderID, ProductID, ProductName, UnitPrice, Quantity FROM CartView";
            SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn, tran);
            detailsCmd.Parameters.AddWithValue("@OrderID", orderId);
            detailsCmd.ExecuteNonQuery();

            // 3. Insert into Payment
            string paymentQuery = "INSERT INTO Payment (OrderID, PaymentMethod, Amount, TransactionID) " +
                                  "VALUES (@OrderID, @Method, @Amount, @TransactionID)";
            SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, tran);
            paymentCmd.Parameters.AddWithValue("@OrderID", orderId);
            paymentCmd.Parameters.AddWithValue("@Method", method);
            paymentCmd.Parameters.AddWithValue("@Amount", netAmount);
            paymentCmd.Parameters.AddWithValue("@TransactionID", (object)txnId ?? DBNull.Value);
            paymentCmd.ExecuteNonQuery();

            return orderId; // return the newly created OrderID
        }

        private void ClearCart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM CartView; DBCC CHECKIDENT ('CartView', RESEED, 0);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

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
                ADD();
                //using (SqlConnection conn = new SqlConnection(connectionString))
                //{
                //    conn.Open();
                //    SqlTransaction tran = conn.BeginTransaction();

                //    try
                //    {
                //        int orderId = SaveOrderAndPayment(conn, tran, method, netAmount, txnId);

                //        tran.Commit();

                //        MessageBox.Show($"✅ Payment successful. Order ID: {orderId}",
                //                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        ClearCart(); // empty cart after saving

                //        this.Close(); // close payment form
                //    }
                //    catch (Exception ex)
                //    {
                //        tran.Rollback();
                //        MessageBox.Show("Transaction failed: " + ex.Message,
                //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message,
                                "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ADD()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1️⃣ Insert Customer
                    string insertCustomerQuery = @"
                INSERT INTO Customer (Name, Phone) 
                VALUES (@Name, @Phone);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdCustomer = new SqlCommand(insertCustomerQuery, conn);
                    cmdCustomer.Parameters.AddWithValue("@Name", txtCusName.Text.Trim());
                    //cmdCustomer.Parameters.AddWithValue("@Email", txtCustomerEmail.Text.Trim());
                    cmdCustomer.Parameters.AddWithValue("@Phone", txtCusPhone.Text.Trim());

                    int customerId = Convert.ToInt32(cmdCustomer.ExecuteScalar());

                    // 2️⃣ Insert Order
                    //string insertOrderQuery = @"INSERT INTO Orders (CustomerID, TotalAmount) 
                    //                            VALUES (@CustomerID, @TotalAmount);
                    //                                    SELECT SCOPE_IDENTITY();";


                    string insertOrderQuery =
                    "INSERT INTO Orders (CustomerID, TotalAmount) VALUES (" + customerId + ", " + Convert.ToDecimal(lblNetAmm_pay.Text) + "); " +
                    "SELECT SCOPE_IDENTITY();";



                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn);
                    //cmdOrder.Parameters.AddWithValue("@CustomerID", customerId);
                    //cmdOrder.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(lblNetAmm_pay.Text));

                    int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());



                    // 3️⃣ Insert into OrderDetails (loop dgvCartView)
                    //foreach (DataGridViewRow row in dgvCartView.Rows)
                    //{
                    //    if (row.IsNewRow) continue;

                    //    string insertDetailQuery = @"
                    //INSERT INTO OrderDetails (OrderID, ProductName, ProductID, Quantity, UnitPrice) 
                    //VALUES (@OrderID, @ProductName, @ProductID, @Quantity, @UnitPrice)";

                    //    SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn);
                    //    cmdDetail.Parameters.AddWithValue("@OrderID", orderId);
                    //    cmdDetail.Parameters.AddWithValue("@ProductName", row.Cells["ProductName"].Value);
                    //    cmdDetail.Parameters.AddWithValue("@ProductID", row.Cells["ProductID"].Value);
                    //    cmdDetail.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                    //    cmdDetail.Parameters.AddWithValue("@UnitPrice", row.Cells["UnitPrice"].Value);

                    //    cmdDetail.ExecuteNonQuery();
                    //}
                    string insertDetailQuery = @"
                    INSERT INTO OrderDetails (OrderID, ProductName, ProductID, Quantity, UnitPrice)
                    SELECT @OrderID, ProductName, ProductID, Quantity, UnitPrice
                    FROM CartView";
                    SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn);
                        
                    cmdDetail.Parameters.AddWithValue("@OrderID", orderId);
                    cmdDetail.ExecuteNonQuery();
                        
                    


                    // 4️⃣ Insert Payment
                    string insertPaymentQuery = @"
                INSERT INTO Payment (OrderID, PaymentMethod, Amount, TransactionID) 
                VALUES (@OrderID, @PaymentMethod, @Amount, @TransactionID)";

                    SqlCommand cmdPayment = new SqlCommand(insertPaymentQuery, conn);
                    cmdPayment.Parameters.AddWithValue("@OrderID", orderId);
                    cmdPayment.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem.ToString());
                    cmdPayment.Parameters.AddWithValue("@Amount", Convert.ToDecimal(lblNetAmm_pay.Text));
                    cmdPayment.Parameters.AddWithValue("@TransactionID", txnId.ToString());

                    cmdPayment.ExecuteNonQuery();

                    // ✅ Success Message
                    MessageBox.Show("Payment successful! Order saved.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
