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
            totalpricelb.Text = totalprice.ToString()+tk;
            totalsalelb.Text = totalsale.ToString()+tk;

            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsaleman.ToString();

            totalProfit = totalprice - totalsale;
            profitlb.Text = totalProfit.ToString() +tk;

            chart1.Titles.Add("Cost of A Shop");
            chart1.Series["S1"].Points.AddXY("  Price", totalprice.ToString());
            chart1.Series["S1"].Points[0].Color = Color.SeaGreen;

            chart1.Series["S1"].Points.AddXY("  Sale", totalsale.ToString());
            chart1.Series["S1"].Points[1].Color = Color.DarkOrange;

            chart1.Series["S1"].Points.AddXY("  Profit", totalProfit.ToString());
            chart1.Series["S1"].Points[2].Color = Color.MediumOrchid;

            employeChart.Titles.Add("Employee Ratio");
            
            employeChart.Series["EMP"].Points.AddXY("Cashier", totalcashier.ToString());
            employeChart.Series["EMP"].Points[0].Color = Color.Green;

            employeChart.Series["EMP"].Points.AddXY("Salesman", totalsaleman.ToString());
            employeChart.Series["EMP"].Points[1].Color = Color.Purple;
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
                    SqlCommand commandCashier = new SqlCommand(totalCashier, connection);
                    SqlCommand commandSaleman = new SqlCommand(totalSaleman, connection);

                    SqlDataReader readerSum = commandSum.ExecuteReader();
                    if (readerSum.Read())
                    {
                        totalprice = readerSum.IsDBNull(0) ?  0 :  readerSum.GetDouble(0);
                    }
                    readerSum.Close();

                    SqlDataReader readerCashier = commandCashier.ExecuteReader();
                    if (readerCashier.Read())
                    {
                        totalcashier = readerCashier.IsDBNull(0) ? 0 : readerCashier.GetInt32(0);
                    }
                    readerCashier.Close();
                    
                    SqlDataReader readerSaleman = commandSaleman.ExecuteReader();
                    if (readerSaleman.Read())
                    {
                        totalsaleman = readerSaleman.IsDBNull(0) ? 0 : readerSaleman.GetInt32(0);
                    }
                    readerSaleman.Close();
                   
                    SqlDataAdapter adapter = new SqlDataAdapter(commandSum);
                    SqlCommand commandSale = new SqlCommand(totalSale, connection);
                    SqlDataReader readerSale = commandSale.ExecuteReader();
                    if (readerSale.Read())
                    {
                        totalsale = readerSale.IsDBNull(0) ? 0 : readerSale.GetDouble(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
