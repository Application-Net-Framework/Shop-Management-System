
using App.UI_Forms.Admin;
using App.UI_Forms.Cashier;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace App
{
    public partial class mainCashier : Form
    {
        int RowID = -1;
        static int orderid = -1;
        private string cashierName;
        //readonly string connectionString = @"Data Source=DESKTOP-897BHIU\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //string connectionString = @"Data Source=HACIN\SQLEXPRESS;Initial Catalog=GSMSdb;Integrated Security=True";
        //public mainCashier()
        //{
        //    InitializeComponent();
        //    PanleVisible();
        //    //show();
        //    //CartView();
        //    //clear();
        //    //clearCart();
        //    //LoadCategories();
        //    //LoadDashboardCards();
        //    //cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
        //    //pnlHome.Visible = true;
        //    ucPnl_Home1.Visible = true;
        //}
        public mainCashier(string name)
        {
            InitializeComponent();
            cashierName = name;
            PanleVisible();
            ucPnl_Home1.Visible = true;
        }

        private void PositionLabels()
        {
            // Center lblWelcome horizontally in pnlWelcome
            lblWelcome.Left = (pnlWelcome.Width - lblWelcome.Width) / 2;
            lblWelcome.Top = (pnlWelcome.Height - lblWelcome.Height) / 2;

            // Place lblTimer at the right edge with small padding
            lblTimer.Left = pnlWelcome.Width - lblTimer.Width - 10;
            lblTimer.Top = (pnlWelcome.Height - lblTimer.Height) / 2;
        }



        private void Cashier_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(952, 602);

            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            //totalPriceAfterDiscount();
            //lblTimer.Text = DateTime.Now.ToString("dddd, MMM dd yyyy HH:mm:ss");
            //lblTimer.Text = DateTime.Now.ToString("dddd, MMM dd yyyy hh:mm:ss tt");
            //PositionLabels();
            lblWelcome.Text = "Welcome, " + cashierName + "!";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) =>
            {
                lblTimer.Text = DateTime.Now.ToString("dddd, MMM dd yyyy hh:mm:ss tt");
                PositionLabels(); // Recenter after text width changes
            };
            timer.Start();
        }
        private void PanleVisible()
        {
            // Reset panel positions
            //ucPnl_Order1.Location = new Point(245, 46);
            //ucPnl_Home1.Location = new Point(245, 46);

            ucPnl_Home1.Visible = false;
            ucPnl_Order1.Visible = false;
            ucPnl_Product1.Visible = false;

            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void ShowPanel(string panelName)
        {
            switch (panelName)
            {
                case "Home":
                    pnlWelcome.Size = new Size(904, 32);
                    this.ClientSize = new Size(952, 602);

                    PanleVisible();
                    ucPnl_Home1.LoadDashboardCards();
                    ucPnl_Home1.LoadMonthlySales();
                    ucPnl_Home1.Visible = true;
                    break;

                case "Product":
                    pnlWelcome.Size = new Size(1140, 32);
                    this.ClientSize = new Size(1183, 602);
                    ucPnl_Product1.clear();
                    ucPnl_Product1.clearCart();
                    ucPnl_Product1.clearSearch();

                    PanleVisible();
                    ucPnl_Product1.Visible = true;
                    break;

                case "Orders":
                    pnlWelcome.Size = new Size(904, 32);
                    this.ClientSize = new Size(952, 602);
                    ucPnl_Order1.RefreshData();

                    PanleVisible();
                    ucPnl_Order1.Visible = true;
                    break;

                case "Logout":
                    this.Hide();
                    LogPage loginForm = new LogPage();
                    loginForm.ShowDialog();
                    this.Close();
                    break;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanel("Home");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowPanel("Product");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowPanel("Orders");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ShowPanel("Logout");
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(25, 112, 255);
            btnProduct.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.FromArgb(255, 255, 255);
            btnProduct.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(255, 255, 255);
            btnHome.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(25, 112, 255);
            btnHome.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(255, 255, 255);
            btnOrder.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(25, 112, 255);
            btnOrder.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void pnlWelcome_Resize(object sender, EventArgs e)
        {
            PositionLabels();
        }

    }
}
