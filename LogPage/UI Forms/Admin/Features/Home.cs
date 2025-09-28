using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager
{
    public partial class Home : UserControl
    {
        
        private readonly string[] connectionStrings = new string[] {
            @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;",
            @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True"
        };
        
        
        private Label lblTotalSaleTitle;
        private Label lblTotalSaleAmount;
        private Label lblTotalSaleDate;
        
        
        private Label lblTotalProductTitle;
        private Label lblTotalProductCount;
        private Label lblTotalProductValue;
        
        
        private Label lblTotalEmployeeTitle;
        private Label lblTotalEmployeeCount;
        private Label lblTotalEmployeeStatus;

        public Home()
        {
            InitializeComponent();
            
            
            SetupTotalSalesPanel();
            SetupTotalProductPanel();
            SetupTotalEmployeePanel();
            
            
            LoadDailySalesData();
            LoadTotalProductsData();
            LoadTotalEmployeeData();
            
            
            LoadEmployeeData();
        }

        private void SetupTotalSalesPanel()
        {
           
            lblTotalSaleTitle = new Label
            {
                Text = "Today's Sales",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = pnlTotalSale.Width - 10,
                Height = 30,
                Location = new Point(5, 10)
            };
            
            
            lblTotalSaleAmount = new Label
            {
                Text = "$0.00",
                Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = pnlTotalSale.Width - 10,
                Height = 40,
                Location = new Point(5, 50)
            };
            
            
            lblTotalSaleDate = new Label
            {
                Text = DateTime.Now.ToString("dddd, MMMM d, yyyy"),
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = pnlTotalSale.Width - 10,
                Height = 20,
                Location = new Point(5, 100)
            };
            
           
            pnlTotalSale.Controls.Add(lblTotalSaleTitle);
            pnlTotalSale.Controls.Add(lblTotalSaleAmount);
            pnlTotalSale.Controls.Add(lblTotalSaleDate);
            
            
            pnlTotalSale.Paint += pnlTotalSale_Paint;
        }
        
        private void SetupTotalProductPanel()
        {
           
            lblTotalProductTitle = new Label
            {
                Text = "Total Products",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalProduct.Width - 10,
                Height = 30,
                Location = new Point(5, 10)
            };
            
          
            lblTotalProductCount = new Label
            {
                Text = "0",
                Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold),
                ForeColor = Color.Navy,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalProduct.Width - 10,
                Height = 50,
                Location = new Point(5, 50)
            };
            
            
            lblTotalProductValue = new Label
            {
                Text = "Items in inventory",
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalProduct.Width - 10,
                Height = 20,
                Location = new Point(5, 100)
            };
            
            
            totalProduct.Controls.Add(lblTotalProductTitle);
            totalProduct.Controls.Add(lblTotalProductCount);
            totalProduct.Controls.Add(lblTotalProductValue);
            
            totalProduct.Paint += TotalProduct_Paint;
        }
        
        private void SetupTotalEmployeePanel()
        {
            
            lblTotalEmployeeTitle = new Label
            {
                Text = "Total Employees",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalEmp.Width - 10,
                Height = 30,
                Location = new Point(5, 10)
            };
            
            
            lblTotalEmployeeCount = new Label
            {
                Text = "0",
                Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalEmp.Width - 10,
                Height = 50,
                Location = new Point(5, 50)
            };
            
            lblTotalEmployeeStatus = new Label
            {
                Text = "Active team members",
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = totalEmp.Width - 10,
                Height = 20,
                Location = new Point(5, 100)
            };
            
            
            totalEmp.Controls.Add(lblTotalEmployeeTitle);
            totalEmp.Controls.Add(lblTotalEmployeeCount);
            totalEmp.Controls.Add(lblTotalEmployeeStatus);
            
            
            totalEmp.Paint += TotalEmployee_Paint;
        }
        
        private void TotalEmployee_Paint(object sender, PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
                totalEmp.ClientRectangle,
                Color.FromArgb(255, 240, 240),
                Color.FromArgb(245, 225, 225),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, totalEmp.ClientRectangle);
            }
            
            
            Rectangle rect = new Rectangle(0, 0, totalEmp.Width - 1, totalEmp.Height - 1);
            using (Pen pen = new Pen(Color.FromArgb(200, 180, 180), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        
        private void TotalProduct_Paint(object sender, PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
                totalProduct.ClientRectangle,
                Color.FromArgb(240, 240, 255),
                Color.FromArgb(225, 225, 245),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, totalProduct.ClientRectangle);
            }
            
           
            Rectangle rect = new Rectangle(0, 0, totalProduct.Width - 1, totalProduct.Height - 1);
            using (Pen pen = new Pen(Color.FromArgb(180, 180, 200), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        
        private void LoadDailySalesData()
        {
            bool success = false;
            decimal totalSales = 0;
            
            
            foreach (string connectionString in connectionStrings)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        
                        string salesAmountQuery = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                        using (SqlCommand cmd = new SqlCommand(salesAmountQuery, conn))
                        {
                            object result = cmd.ExecuteScalar();
                            totalSales = Convert.ToDecimal(result);
                            success = true;
                            break; 
                        }
                    }
                }
                catch
                {
                    
                    continue;
                }
            }
            
            
            lblTotalSaleAmount.Text = success ? totalSales.ToString("C") : "$0.00";
        }
        
        private void LoadTotalProductsData()
        {
            
            foreach (string connectionString in connectionStrings)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        
                        try
                        {
                           
                            string productQuery = "SELECT COUNT(*) FROM Product";
                            using (SqlCommand cmd = new SqlCommand(productQuery, conn))
                            {
                                object result = cmd.ExecuteScalar();
                                int productCount = Convert.ToInt32(result);
                                lblTotalProductCount.Text = productCount.ToString("N0"); 
                                
                                
                                if (productCount > 0)
                                {
                                    
                                    try
                                    {
                                        string valueQuery = "SELECT SUM(Stock) FROM Product";
                                        using (SqlCommand valueCmd = new SqlCommand(valueQuery, conn))
                                        {
                                            object valueResult = valueCmd.ExecuteScalar();
                                            if (valueResult != null && valueResult != DBNull.Value)
                                            {
                                                int totalStock = Convert.ToInt32(valueResult);
                                                lblTotalProductValue.Text = $"Total Stock: {totalStock:N0} units";
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        lblTotalProductValue.Text = "Items in inventory";
                                    }
                                }
                                return; 
                            }
                        }
                        catch
                        {
                           
                            try
                            {
                                string stockQuery = "SELECT COUNT(*) FROM Stock";
                                using (SqlCommand cmd = new SqlCommand(stockQuery, conn))
                                {
                                    object result = cmd.ExecuteScalar();
                                    int stockCount = Convert.ToInt32(result);
                                    lblTotalProductCount.Text = stockCount.ToString("N0");
                                    lblTotalProductValue.Text = "Items in inventory";
                                    return; // Exit if successful
                                }
                            }
                            catch
                            {
                                
                            }
                        }
                    }
                }
                catch
                {
                    
                }
            }
            
            
            lblTotalProductCount.Text = "0";
            lblTotalProductValue.Text = "Items in inventory";
        }
        
        private void LoadTotalEmployeeData()
        {
           
            foreach (string connectionString in connectionStrings)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        
                        try
                        {
                            string employeeQuery = "SELECT COUNT(*) FROM AddEmployee";
                            using (SqlCommand cmd = new SqlCommand(employeeQuery, conn))
                            {
                                object result = cmd.ExecuteScalar();
                                int employeeCount = Convert.ToInt32(result);
                                lblTotalEmployeeCount.Text = employeeCount.ToString("N0");
                                
                                
                                lblTotalEmployeeStatus.Text = employeeCount == 1 
                                    ? "Active team member" 
                                    : "Active team members";
                                return; 
                            }
                        }
                        catch
                        {
                            // Try Employee table as fallback
                            try
                            {
                                string empQuery = "SELECT COUNT(*) FROM Employee";
                                using (SqlCommand cmd = new SqlCommand(empQuery, conn))
                                {
                                    object result = cmd.ExecuteScalar();
                                    int empCount = Convert.ToInt32(result);
                                    lblTotalEmployeeCount.Text = empCount.ToString("N0");
                                    
                                    
                                    lblTotalEmployeeStatus.Text = empCount == 1 
                                        ? "Active team member" 
                                        : "Active team members";
                                    return; 
                                }
                            }
                            catch
                            {
                                
                            }
                        }
                    }
                }
                catch
                {
                    
                }
            }
            
            
            lblTotalEmployeeCount.Text = "0";
            lblTotalEmployeeStatus.Text = "Active team members";
        }
        
        private void LoadEmployeeData()
        {
            
            foreach (string connectionString in connectionStrings)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        try
                        {
                            string employeeQuery = "SELECT ID, Name, Email, Phone_Number FROM AddEmployee";
                            using (SqlDataAdapter adapter = new SqlDataAdapter(employeeQuery, conn))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                
                                
                                dataGridView1.DataSource = dataTable;
                                return; 
                            }
                        }
                        catch
                        {
                            
                            try
                            {
                                string altQuery = "SELECT * FROM Employee";
                                using (SqlDataAdapter adapter = new SqlDataAdapter(altQuery, conn))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);
                                    dataGridView1.DataSource = dataTable;
                                    return; 
                                }
                            }
                            catch
                            {
                                
                            }
                        }
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void pnlTotalSale_Paint(object sender, PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
                pnlTotalSale.ClientRectangle,
                Color.FromArgb(240, 240, 240),
                Color.FromArgb(220, 220, 220),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, pnlTotalSale.ClientRectangle);
            }
            
            
            Rectangle rect = new Rectangle(0, 0, pnlTotalSale.Width - 1, pnlTotalSale.Height - 1);
            using (Pen pen = new Pen(Color.FromArgb(180, 180, 180), 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
