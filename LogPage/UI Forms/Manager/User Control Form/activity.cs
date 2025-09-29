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

            this.DailyRecordsChart.Series["Total Price"].Points.AddXY("totalprice",totalprice);
            this.DailyRecordsChart.Series["Total Sale"].Points.AddXY("totalsale", totalsale);

            this.employeChart.Series["Cashier"].Points.AddXY("totalcashier", totalcashier);
            this.employeChart.Series["SalesMan"].Points.AddXY("totalsaleman", totalsaleman);
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
    }
}
