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
        public float totalSales;
        public float totalPrice;

        public int totalsalesman;
        public int totalcashier;
        
        public int cashierSalaryAmount = 1000;  
        public int salesmanSalaryAmount = 1200;  

        public int netIncomeSalesman;
        public int netIncomeCashier;

        public string ConnectionString ="";
        public report()
        {
            InitializeComponent();
            
            //loadDatabase();
            
            cashierEmpLb.Text = totalcashier.ToString();
            salemanLb.Text = totalsalesman.ToString();
            totalpricelb.Text = totalPrice.ToString();
            totalsalelb.Text = totalSales.ToString();

            netIncomeCashier = totalcashier * cashierSalaryAmount;
            netIncomeSalesman = totalsalesman * salesmanSalaryAmount;

            saleManSalary.Text = netIncomeSalesman.ToString();
            cashierSalary.Text = netIncomeCashier.ToString();

        }

        public void loadDatabase()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string TotalPrice = "SELECT  SUM(ProductPrice*BuyQuantity)FROM Product";
                    string TotalSales = "SELECT SUM((ProductPrice*(BuyQuantity-SaleQuantity))) FROM Products WHERE Status = 'sale'";
                    string TotalCashier = "SELECT COUNT(*) FROM Employee WHERE role = 'Cashier'";
                    string TotalSalesman = "SELECT COUNT(*) FROM Employee WHERE role = 'salesman'";


                    connection.Open();
                    SqlCommand totalprice = new SqlCommand(TotalPrice, connection);
                    SqlCommand totalsales = new SqlCommand(TotalSales, connection);

                    SqlCommand totalcashier = new SqlCommand(TotalCashier, connection);
                    SqlCommand totalsalesman = new SqlCommand(TotalSalesman, connection);

                    SqlDataReader readerPrice = totalprice.ExecuteReader();
                    if (readerPrice.Read())
                    {
                        totalPrice = readerPrice.IsDBNull(0) ? 0 : readerPrice.GetFloat(0);
                    }
                    readerPrice.Close();

                    SqlDataReader readerSales = totalsales.ExecuteReader();
                    if (readerSales.Read())
                    {
                        totalSales = readerSales.IsDBNull(0) ? 0 : readerSales.GetFloat(0);
                    }
                    readerSales.Close();


                    SqlDataReader readerCashier = totalcashier.ExecuteReader();
                    if (readerCashier.Read())
                    {
                        totalcashier = readerCashier.IsDBNull(0) ? 0 : readerCashier.GetInt32(0);
                    }
                    readerCashier.Close();

                    SqlDataReader readerSalesman = totalsalesman.ExecuteReader();
                    if (readerSalesman.Read())
                    {
                        totalsalesman = readerSalesman.IsDBNull(0) ? 0 : readerSalesman.GetInt32(0);

                    }
                    readerCashier.Close();
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
