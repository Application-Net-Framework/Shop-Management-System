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

        string ConnectionString;
        public activity()
        {
            InitializeComponent();
            
            loadDatabase();

            totalpricelb.Text = totalprice.ToString();
            totalsalelb.Text = totalsale.ToString();
            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsaleman.ToString();

            this.DailyRecordsChart.Series["Total Price"].Points.AddXY("totalprice",100);
            this.DailyRecordsChart.Series["Total Price"].Points.AddXY("totalsale", 100);
            this.DailyRecordsChart.Series["Total Price"].Points.AddXY("totalcashier", 100);
            this.DailyRecordsChart.Series["Total Price"].Points.AddXY("totalsaleman", 100);
        }
        public void loadDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    
                    string totalSum = "SELECT SUM(TotalPrice) AS TotalPrice, SUM(Sale) AS TotalSale FROM Orders";
                    string totalCashier = "SELECT COUNT(*) AS TotalCashier FROM Employees WHERE Role = 'Cashier'";
                    string totalSaleman = "SELECT COUNT(*) AS TotalSaleman FROM Employees WHERE Role = 'Saleman'";
                    
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
