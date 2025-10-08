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

        string ConnectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public activity()
        {
            InitializeComponent();
            
            // loadDatabase();

            totalpricelb.Text = totalprice.ToString();
            totalsalelb.Text = totalsale.ToString();
            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsaleman.ToString();

            chart1.Titles.Add("Cost of A Shop");
            chart1.Series["S1"].Points.AddXY("Total Price","33");
            chart1.Series["S1"].Points.AddXY("Total Sale", "33");
            chart1.Series["S1"].Points.AddXY("Total Cost", "33");

            employeChart.Titles.Add("Employee Ratio");
            employeChart.Series["EMP"].Points.AddXY("Cashier", "33");
            employeChart.Series["EMP"].Points.AddXY("Salesman", "33");
        }
        public void loadDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    string totalSum = "SELECT SUM([Product Price]) AS TotalPrice, SUM([Product Sale Price]) AS TotalSale FROM [Daily Activity]";
                    string totalCashier = "SELECT COUNT(*) AS TotalCashier FROM [Daily Activity] WHERE Role = 'Cashier'";
                    string totalSaleman = "SELECT COUNT(*) AS TotalSaleman FROM [Daily Activity] WHERE Role = 'Salesman'";


                    connection.Open();
                    SqlCommand commandSum = new SqlCommand(totalSum, connection);
                    SqlCommand commandCashier = new SqlCommand(totalCashier, connection);
                    SqlCommand commandSaleman = new SqlCommand(totalSaleman, connection);

                    SqlDataReader readerSum = commandSum.ExecuteReader();
                    if (readerSum.Read())
                    {
                        totalprice = readerSum.IsDBNull(0) ? 0 : readerSum.GetDouble(0);
                        totalsale = readerSum.IsDBNull(1) ? 0 : readerSum.GetDouble(1);
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
