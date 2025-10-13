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

        public string ConnectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        public report()
        {
            InitializeComponent();
            
            loadDatabase();
            
            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsalesman.ToString();

            totalpricelb.Text = totalPrice.ToString("0.00");
            totalsalelb.Text = totalSales.ToString("0.00");

            netIncomeCashier = totalcashier * cashierSalaryAmount;
            netIncomeSalesman = totalsalesman * salesmanSalaryAmount;

            saleManSalary.Text = netIncomeSalesman.ToString();
            cashierSalary.Text = netIncomeCashier.ToString();

            chart1.Titles.Add("Employee Ratio");
            chart1.Series["S1"].Points.AddXY("Cashier", totalcashier);
            chart1.Series["S1"].Points[0].Color = Color.Green;

            chart1.Series["S1"].Points.AddXY("Saleman", totalsalesman);
            chart1.Series["S1"].Points[1].Color = Color.Purple;

            chart2.Titles.Add("Cost of a shop");           
            chart2.Series["S2"].Points.AddXY("   Price", (double)totalPrice);
            chart2.Series["S2"].Points[0].Color = Color.FromArgb(67, 129, 101);

            chart2.Series["S2"].Points.AddXY("   Sale", (double)totalSales);
            chart2.Series["S2"].Points[1].Color = Color.FromArgb(255, 181, 76);

            chart2.Series["S2"].Points.AddXY("Sales Man Salary", netIncomeSalesman);
            chart2.Series["S2"].Points[2].Color = Color.FromArgb(81, 14, 126);

            chart2.Series["S2"].Points.AddXY("Cashier Salary", netIncomeCashier);
            chart2.Series["S2"].Points[3].Color = Color.FromArgb(54, 87, 61);
        }

        public void loadDatabase()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string TotalPrice = "SELECT SUM(Price * Stock) AS TotalPrice FROM Product";
                    string TotalSales = "SELECT SUM(TotalAmount) AS TotalSales FROM Orders";

                    string TotalCashier = "SELECT COUNT(*) AS TotalCashier FROM Employees WHERE Role = 'Cashier'";
                    string TotalSalesman = "SELECT COUNT(*) AS TotalSalesman FROM Employees WHERE Role = 'Salesman'";

                    connection.Open();
                    SqlCommand cmdTotalPrice = new SqlCommand(TotalPrice, connection);
                    SqlCommand cmdTotalSales = new SqlCommand(TotalSales, connection);
                    SqlCommand cmdTotalCashier = new SqlCommand(TotalCashier, connection);
                    SqlCommand cmdTotalSalesman = new SqlCommand(TotalSalesman, connection);
                    
                    object priceResult = cmdTotalPrice.ExecuteScalar();
                    totalPrice = (priceResult == DBNull.Value || priceResult == null) ? 0 : Convert.ToDecimal(priceResult);
                    
                    object salesResult = cmdTotalSales.ExecuteScalar();
                    totalSales = (salesResult == DBNull.Value || salesResult == null) ? 0 : Convert.ToDecimal(salesResult);
                    
                    object cashierResult = cmdTotalCashier.ExecuteScalar();
                    totalcashier = (cashierResult == DBNull.Value || cashierResult == null) ? 0 : Convert.ToInt32(cashierResult);
                    
                    object salesmanResult = cmdTotalSalesman.ExecuteScalar();
                    totalsalesman = (salesmanResult == DBNull.Value || salesmanResult == null) ? 0 : Convert.ToInt32(salesmanResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
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
