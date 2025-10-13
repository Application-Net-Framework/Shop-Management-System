using App.UI_Forms.Admin;
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

namespace App.UI_Forms.Manager
{
    public partial class activity : UserControl
    {
        public double totalprice;
        public double totalsale;
        public int totalcashier;
        public int totalsaleman;
        public double totalProfit;

        string ConnectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public activity()
        {
            InitializeComponent();
            
            loadDatabase();
            string tk = "Tk";
            totalpricelb.Text = totalprice.ToString() + tk;
            totalsalelb.Text = totalsale.ToString() + tk;

            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsaleman.ToString();

            totalProfit = totalprice + totalsale;
            profitlb.Text = totalProfit.ToString() + tk;

            chart1.Titles.Add("Cost of A Shop");
            chart1.Series["S1"].Points.AddXY("  Price", totalprice);
            chart1.Series["S1"].Points[0].Color = Color.FromArgb(67, 129, 101); 

            chart1.Series["S1"].Points.AddXY("  Sale", totalsale);
            chart1.Series["S1"].Points[1].Color = Color.FromArgb(255, 181, 76);

            chart1.Series["S1"].Points.AddXY("  Profit", totalProfit);
            chart1.Series["S1"].Points[2].Color = Color.FromArgb(202, 127, 220);

            employeChart.Titles.Add("Employee Ratio");
            
            employeChart.Series["EMP"].Points.AddXY("Cashier", totalcashier);
            employeChart.Series["EMP"].Points[0].Color = Color.FromArgb(54, 87, 61);

            employeChart.Series["EMP"].Points.AddXY("Salesman", totalsaleman);
            employeChart.Series["EMP"].Points[1].Color = Color.FromArgb(81, 14, 126);
        }
        public void loadDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string totalSum = "SELECT SUM(Price) AS TotalPrice FROM Product";
                    string totalSale = "SELECT SUM(TotalAmount) AS TotalCustomerAmount FROM Orders";
                    string totalCashier = "SELECT COUNT(*) AS TotalCashier FROM Employees WHERE LOWER(Role) = 'cashier'";
                    string totalSaleman = "SELECT COUNT(*) AS TotalSaleman FROM Employees WHERE LOWER(Role) = 'salesman'";

                    connection.Open();

                    SqlCommand commandSum = new SqlCommand(totalSum, connection);
                    object priceResult = commandSum.ExecuteScalar();
                    totalprice = priceResult == null || priceResult == DBNull.Value ? 0 : Convert.ToDouble(priceResult);

                    SqlCommand commandCashier = new SqlCommand(totalCashier, connection);
                    object cashierResult = commandCashier.ExecuteScalar();
                    totalcashier = cashierResult == null || cashierResult == DBNull.Value ? 0 : Convert.ToInt32(cashierResult);

                    SqlCommand commandSaleman = new SqlCommand(totalSaleman, connection);
                    object salemanResult = commandSaleman.ExecuteScalar();
                    totalsaleman = salemanResult == null || salemanResult == DBNull.Value ? 0 : Convert.ToInt32(salemanResult);

                    SqlCommand commandSale = new SqlCommand(totalSale, connection);
                    object saleResult = commandSale.ExecuteScalar();
                    totalsale = saleResult == null || saleResult == DBNull.Value ? 0 : Convert.ToDouble(saleResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity data: " + ex.Message);
            }
        }
        private void totalpricelb_Click(object sender, EventArgs e)
        {

        }

        private void activity_Load(object sender, EventArgs e)
        {

        }

        private void employeChart_Click(object sender, EventArgs e)
        {

        }
    }
}
