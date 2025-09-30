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

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class report : UserControl
    {
        public decimal totalSales;
        public decimal totalPrice;

        public int totalsalesman;
        public int totalcashier;
        
        public int cashierSalaryAmount = 1000;  
        public int salesmanSalaryAmount = 1200;  

        public int netIncomeSalesman;
        public int netIncomeCashier;

        public string ConnectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public report()
        {
            InitializeComponent();
            
           // loadDatabase();
            
            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsalesman.ToString();
            totalpricelb.Text = totalPrice.ToString();
            totalsalelb.Text = totalSales.ToString();

            netIncomeCashier = totalcashier * cashierSalaryAmount;
            netIncomeSalesman = totalsalesman * salesmanSalaryAmount;

            saleManSalary.Text = netIncomeSalesman.ToString();
            cashierSalary.Text = netIncomeCashier.ToString();

            this.EmployeeChart.Series["Sales Man"].Points.AddXY("Sales Man", totalsalesman);
            this.EmployeeChart.Series["Cashier"].Points.AddXY("Cashier", totalcashier);

            this.MoneyPiChart.Series["TotalPrice"].Points.AddXY("TotalPrice", totalPrice);
            this.MoneyPiChart.Series["TotalSales"].Points.AddXY("TotalSales", totalSales);

            this.MoneyPiChart.Series["SalesManSalary"].Points.AddXY("SalesManSalary", netIncomeSalesman);
            this.MoneyPiChart.Series["CashierSalary"].Points.AddXY("CashierSalary", netIncomeCashier);
        }

        public void loadDatabase()
        {
            try
            {
 
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string TotalPrice = "SELECT SUM(ProductPrice * BuyQuantity) FROM Product";
                    string TotalSales = "SELECT SUM(ProductPrice * SaleQuantity) AS TotalSales FROM Product";
                    string TotalCashier = "SELECT COUNT(*) FROM Employee WHERE Role = 'Cashier'";
                    string TotalSalesman = "SELECT COUNT(*) FROM Employee WHERE Role = 'Salesman'";

                    connection.Open();
                    SqlCommand cmdTotalPrice = new SqlCommand(TotalPrice, connection);
                    SqlCommand cmdTotalSales = new SqlCommand(TotalSales, connection);
                    SqlCommand cmdTotalCashier = new SqlCommand(TotalCashier, connection);
                    SqlCommand cmdTotalSalesman = new SqlCommand(TotalSalesman, connection);
                    
                    SqlDataReader readerPrice = cmdTotalPrice.ExecuteReader();
                    if (readerPrice.Read())
                    {
                        totalPrice = readerPrice.IsDBNull(0) ? 0 : Convert.ToDecimal(readerPrice[0]);
                    }
                    readerPrice.Close();
                    
                    SqlDataReader readerSales = cmdTotalSales.ExecuteReader();
                    if (readerSales.Read())
                    {
                        totalSales = readerSales.IsDBNull(0) ? 0 : Convert.ToDecimal(readerSales[0]);

                    }
                    readerSales.Close();
                    

                    SqlDataReader readerCashier = cmdTotalCashier.ExecuteReader();
                    if (readerCashier.Read())
                    {
                        totalcashier = readerCashier.IsDBNull(0) ? 0 : readerCashier.GetInt32(0);
                    }
                    readerCashier.Close();

                    SqlDataReader readerSalesman = cmdTotalSalesman.ExecuteReader();
                    if (readerSalesman.Read())
                    {
                        totalsalesman = readerSalesman.IsDBNull(0) ? 0 : readerSalesman.GetInt32(0);
                    }
                    readerSalesman.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
