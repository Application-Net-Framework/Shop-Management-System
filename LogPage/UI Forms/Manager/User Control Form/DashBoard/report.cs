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

            totalpricelb.Text = totalPrice.ToString();
            totalsalelb.Text = totalSales.ToString();

            netIncomeCashier = totalcashier * cashierSalaryAmount;
            netIncomeSalesman = totalsalesman * salesmanSalaryAmount;

            saleManSalary.Text = netIncomeSalesman.ToString();
            cashierSalary.Text = netIncomeCashier.ToString();

            chart1.Titles.Add("Employee Ratio");
            chart1.Series["S1"].Points.AddXY("Cashier", totalcashier.ToString());
            chart1.Series["S1"].Points[0].Color = Color.Green;

            chart1.Series["S1"].Points.AddXY("Saleman", totalsalesman.ToString());
            chart1.Series["S1"].Points[1].Color = Color.Purple;

            chart2.Titles.Add("Cost of a shop");           
            chart2.Series["S2"].Points.AddXY("   Price", totalPrice.ToString());
            chart2.Series["S2"].Points[0].Color = Color.FromArgb(67, 129, 101);

            chart2.Series["S2"].Points.AddXY("   Sale", totalSales.ToString());
            chart2.Series["S2"].Points[1].Color = Color.FromArgb(255, 181, 76);

            chart2.Series["S2"].Points.AddXY("Sales Man Salary", netIncomeSalesman.ToString());
            chart2.Series["S2"].Points[2].Color = Color.FromArgb(81, 14, 126);

            chart2.Series["S2"].Points.AddXY("Cashier Salary", netIncomeCashier.ToString());
            chart2.Series["S2"].Points[3].Color = Color.FromArgb(54, 87, 61);
        }

        public void loadDatabase()
        {
            try
            {
 
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string TotalPrice = "SELECT SUM(Price * Stock) AS TotalPrice FROM Product";
                    string TotalSales = "SELECT SUM(Price * SaleQuantity) AS TotalSales FROM Product";

                    string TotalCashier = "SELECT COUNT(*) AS TotalCashier FROM Employees WHERE Role = 'Cashier'";
                    string TotalSalesman = "SELECT COUNT(*) AS TotalSalesman FROM Employees WHERE Role = 'Salesman'";


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
