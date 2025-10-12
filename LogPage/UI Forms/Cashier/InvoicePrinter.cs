using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class InvoicePrinter
{
    private string _customerName;
    private string _phone;
    private string _method;
    private string _orderId;
    private DataTable _orderItems;

    private decimal _subTotal;
    private decimal _discount;
    private decimal _discountPrct;
    private decimal _total;


    public InvoicePrinter(int orderId)
    {
        _orderId = orderId.ToString();
        LoadOrderData(orderId);
    }

    public void LoadOrderData(int orderId)
    {
        try {
            string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True";
            //string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
            //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";

            string txnId = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Get Order Header (Customer + Payment)
            string headerQuery = @"
            SELECT o.OrderID, o.TotalAmount, o.OrderDate, c.Name AS CustomerName, c.Phone, p.PaymentMethod
            FROM Orders o
            INNER JOIN Customer c ON o.CustomerID = c.CustomerID
            INNER JOIN Payment p ON o.OrderID = p.OrderID
            WHERE o.OrderID = " + orderId + "";

            SqlCommand cmd = new SqlCommand(headerQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _customerName = reader["CustomerName"].ToString();
                _phone = reader["Phone"].ToString();
                _method = reader["PaymentMethod"].ToString();
                _total = Convert.ToDecimal(reader["TotalAmount"]);
            }
            reader.Close();


            // Get Order Items
            string detailQuery = @"
            SELECT ProductID, ProductName, Quantity, UnitPrice, (Quantity * UnitPrice) AS SubTotal FROM OrderDetails
            WHERE OrderID = " + orderId + "";

            SqlDataAdapter da = new SqlDataAdapter(detailQuery, conn);
            _orderItems = new DataTable();
            da.Fill(_orderItems);

            // Calculate SubTotal & Discount
            _subTotal = 0;
            foreach (DataRow row in _orderItems.Rows)
            {
                _subTotal += Convert.ToDecimal(row["SubTotal"]);
            }

            _discount = _subTotal - _total;
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


    }

    public void Print()
    {
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += new PrintPageEventHandler(PrintPage);
        PrintPreviewDialog preview = new PrintPreviewDialog();
        preview.Document = pd;
        preview.ShowDialog();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Font headerFont = new Font("Arial", 12, FontStyle.Bold);
        Font headerFont2 = new Font("Arial", 9, FontStyle.Bold);
        Font bodyFont = new Font("Arial", 10);

        float y = 20;

        // Header
        e.Graphics.DrawString("Invoice", headerFont, Brushes.Black, 250, y);
        y += 40;

        int i = 20;
        // Customer details

        e.Graphics.DrawString("Customer: " + _customerName, bodyFont, Brushes.Black, 20 + i, y); y += 20;
        e.Graphics.DrawString("Phone: " + _phone, bodyFont, Brushes.Black, 20 + i, y); y += 20;
        e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd-MMM-yyyy"), bodyFont, Brushes.Black, 20 + i, y);
        e.Graphics.DrawString("Type: " + _method, bodyFont, Brushes.Black, 260 + i, y); y += 20;
        e.Graphics.DrawString("Order ID: " + _orderId, bodyFont, Brushes.Black, 20 + i, y); y += 20;

        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 20+i, y);
        y += 20;

        // Table Header
        e.Graphics.DrawString("Product", bodyFont, Brushes.Black, 20 + i, y);
        e.Graphics.DrawString("Qty", bodyFont, Brushes.Black, 200 + i, y);
        e.Graphics.DrawString("Price", bodyFont, Brushes.Black, 300 + i, y);
        e.Graphics.DrawString("Sub Total", bodyFont, Brushes.Black, 400 + i, y);
        y += 20;

        // Items
        foreach (DataRow row in _orderItems.Rows)
        {
            e.Graphics.DrawString(row["ProductName"].ToString(), bodyFont, Brushes.Black, 20 + i, y);
            e.Graphics.DrawString(row["Quantity"].ToString(), bodyFont, Brushes.Black, 200 + i, y);
            e.Graphics.DrawString(row["UnitPrice"].ToString(), bodyFont, Brushes.Black, 300 + i, y);
            e.Graphics.DrawString(row["SubTotal"].ToString(), bodyFont, Brushes.Black, 400 + i, y);
            y += 20;
        }
        y += 20;
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", bodyFont, Brushes.Black, 20+i, y);

        y += 20;
        e.Graphics.DrawString("Sub Total       :  " + _subTotal, headerFont, Brushes.Black, 276 + i, y); y += 30;
        e.Graphics.DrawString("Discount        :  " + _discount, headerFont, Brushes.Black, 276 + i, y); y += 30;
        e.Graphics.DrawString("Net Amount   :  " + _total, headerFont, Brushes.Black, 276 + i, y);
    }
}
