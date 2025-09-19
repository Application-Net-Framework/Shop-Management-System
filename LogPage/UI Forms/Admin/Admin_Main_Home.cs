using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Admin
{
    public partial class Admin_Main_Home : Form
    {
        public Admin_Main_Home()
        {
            InitializeComponent();
            panelSide.Height = btnLogOut.Height;
            

            btnCross.Text = "X";
            btnCross.ForeColor = Color.Red;
            btnCross.FlatStyle = FlatStyle.Flat;
            btnCross.FlatAppearance.BorderSize = 0;
            btnCross.Click += btnCross_Click;

            btnMinimize.Text = "_";
            btnMinimize.ForeColor = Color.Black;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Click += btnMinimize_Click;

            btnFullScreen.Text = "□";
            btnFullScreen.ForeColor = Color.Black;
            btnFullScreen.FlatStyle = FlatStyle.Flat;
            btnFullScreen.FlatAppearance.BorderSize = 0;
            btnFullScreen.Click += btnFullScreen_Click;

        }

        private void Admin_Main_Home_Load(object sender, EventArgs e)
        {

        }

        // Helper method to close all panels
        private void CloseAllPanels()
        {
            // Close report panel if it's open
            if (reportExpanded)
            {
                reportpnl.Height = 45;
                reportExpanded = false;
                ReportTimer.Stop();
            }
            
            // Close employee panel if it's open
            if (employeeExpanded)
            {
                pnlEmployee.Height = 45;
                employeeExpanded = false;
                EmployeeTimer.Stop();
            }
            
            // Close product panel if it's open
            if (productExpanded)
            {
                Productpnl.Height = 45;
                productExpanded = false;
                ProductTimer.Stop();
            }
            
            // Close sales panel if it's open
            if (salesExpanded)
            {
                Salepnl.Height = 45;
                salesExpanded = false;
                SalesTimer.Stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnLogOut.Height;
            panelSide.Top = btnLogOut.Top;
            
            // Close all panels when logout button is clicked
            CloseAllPanels();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEmployee.Height;
            panelSide.Top = btnEmployee.Top;
            
            // If employee panel is already open, just close it
            if (employeeExpanded)
            {
                EmployeeTimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open employee panel
            EmployeeTimer.Start();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // If product panel is already open, just close it
            if (productExpanded)
            {
                ProductTimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open product panel
            ProductTimer.Start();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            // If sales panel is already open, just close it
            if (salesExpanded)
            {
                SalesTimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open sales panel
            SalesTimer.Start();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // If report panel is already open, just close it
            if (reportExpanded)
            {
                ReportTimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open report panel
            ReportTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Close all panels when menu button is clicked
            CloseAllPanels();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            // Close all panels when mail button is clicked
            CloseAllPanels();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnFullScreen.Text = "□";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnFullScreen.Text = "❐";
            }
        }

        bool reportExpanded = false;
    
       private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (!reportExpanded)
            {
                reportpnl.Height += 5;   
                if (reportpnl.Height >= 145)
                {
                    reportExpanded = true;
                    ReportTimer.Stop();
                }
            }
            else
            {
                reportpnl.Height -= 5;   
                if (reportpnl.Height <= 45)
                {
                    reportExpanded = false;
                    ReportTimer.Stop();
                }
            }
        }
        bool employeeExpanded = false;

        private void EmployeeTimer_Tick(object sender, EventArgs e)
        {
            if (!employeeExpanded)
            {
                pnlEmployee.Height += 5;
                if (pnlEmployee.Height >= 145)
                {
                    employeeExpanded = true;
                    EmployeeTimer.Stop();
                }
            }
            else
            {
                pnlEmployee.Height -= 5;
                if (pnlEmployee.Height <= 45)
                {
                    employeeExpanded = false;
                    EmployeeTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close all panels when this button is clicked
            CloseAllPanels();
        }
        
        bool productExpanded = false;
        private void ProductTimer_Tick(object sender, EventArgs e)
        {
            if (!productExpanded)
            {
                Productpnl.Height += 5;
                if (Productpnl.Height >= 145)
                {
                    productExpanded = true;
                    ProductTimer.Stop();
                }
            }
            else
            {
                Productpnl.Height -= 5;
                if (Productpnl.Height <= 45)
                {
                    productExpanded = false;
                    ProductTimer.Stop();
                }
            }
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpReports_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {

        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {

        }

        bool salesExpanded = false;

        private void SalesTimer_Tick(object sender, EventArgs e)
        {
            if (!salesExpanded)
            {
                Salepnl.Height += 5;
                if (Salepnl.Height >= 145)
                {
                    salesExpanded = true;
                    SalesTimer.Stop();
                }
            }
            else
            {
                Salepnl.Height -= 5;
                if (Salepnl.Height <= 45)
                {
                    salesExpanded = false;
                    SalesTimer.Stop();
                }
            }
        }
    }
}
