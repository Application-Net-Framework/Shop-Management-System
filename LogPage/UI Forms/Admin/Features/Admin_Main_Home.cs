using App.UI_Forms.Manager;
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
        private const int PANEL_COLLAPSED_HEIGHT = 52;
        private const int PANEL_EXPANDED_HEIGHT = 152;
        
        private bool isDragging = false;
        private Point dragOffset;

        
        bool reportExpanded = false;
        bool employeeExpanded = false;
        bool productExpanded = false;
        bool salesExpanded = false;
        
        
        private bool sideContainerExpanded = true; 
        private int sideContainerFullHeight;
        
        
        private int userId;
        private string userName;

        public Admin_Main_Home(int userId, string userName)
        {
            InitializeComponent();

            
            this.userId = userId;
            this.userName = userName;

            this.Size = new Size(900, 600);
            this.ClientSize = new Size(900, 600);
            
            
            this.MaximumSize = new Size(0, 0);
            this.MinimumSize = new Size(0, 0);

            
            reportpnl.Height = PANEL_COLLAPSED_HEIGHT;
            pnlEmployee.Height = PANEL_COLLAPSED_HEIGHT;
            Productpnl.Height = PANEL_COLLAPSED_HEIGHT;
            Salepnl.Height = PANEL_COLLAPSED_HEIGHT;

            
            SideContainer.Controls.Add(pnlEmployee);
            SideContainer.Controls.Add(Productpnl);
            SideContainer.Controls.Add(Salepnl);
            SideContainer.Controls.Add(reportpnl);
            
            
            sideContainerFullHeight = SideContainer.Height;

           
            btnContainer.Interval = 10;
            btnContainer.Tick += btnContainer_Tick;

           
            this.StartPosition = FormStartPosition.CenterScreen;
            
            
            RepositionPanels();
            
            
            sideContainerExpanded = false;
            SideContainer.Visible = false;
        }
        
        
        public Admin_Main_Home() : this(0, "Unknown")
        {
        }
        
       
        private void EmployeeTimer_Tick(object sender, EventArgs e)
        {
            if (employeeExpanded == false)
            {
                pnlEmployee.Height += 2;
                if (pnlEmployee.Height >= PANEL_EXPANDED_HEIGHT)
                {
                    employeeExpanded = true;
                    EmployeeTimer.Stop();
                    RepositionPanels();
                }
            }
            else
            {
                pnlEmployee.Height -= 2;
                if (pnlEmployee.Height <= PANEL_COLLAPSED_HEIGHT)
                {
                    employeeExpanded = false;
                    EmployeeTimer.Stop();
                    RepositionPanels();
                }
            }
        }
        
        
        private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpanded == false)
            {
                reportpnl.Height += 2;
                if (reportpnl.Height >= PANEL_EXPANDED_HEIGHT)
                {
                    reportExpanded = true;
                    ReportTimer.Stop();
                    RepositionPanels();
                }
            }
            else
            {
                reportpnl.Height -= 2;
                if (reportpnl.Height <= PANEL_COLLAPSED_HEIGHT)
                {
                    reportExpanded = false;
                    ReportTimer.Stop();
                    RepositionPanels();
                }
            }
        }
        
        
        private void ProductTimer_Tick(object sender, EventArgs e)
        {
            if (productExpanded == false)
            {
                Productpnl.Height += 2;
                if (Productpnl.Height >= PANEL_EXPANDED_HEIGHT)
                {
                    productExpanded = true;
                    ProductTimer.Stop();
                    RepositionPanels();
                }
            }
            else
            {
                Productpnl.Height -= 2;
                if (Productpnl.Height <= PANEL_COLLAPSED_HEIGHT)
                {
                    productExpanded = false;
                    ProductTimer.Stop();
                    RepositionPanels();
                }
            }
        }
        
        
        private void SalesTimer_Tick(object sender, EventArgs e)
        {
            if (salesExpanded == false)
            {
                Salepnl.Height += 2;
                if (Salepnl.Height >= PANEL_EXPANDED_HEIGHT)
                {
                    salesExpanded = true;
                    SalesTimer.Stop();
                    RepositionPanels();
                }
            }
            else
            {
                Salepnl.Height -= 2;
                if (Salepnl.Height <= PANEL_COLLAPSED_HEIGHT)
                {
                    salesExpanded = false;
                    SalesTimer.Stop();
                    RepositionPanels();
                }
            }
        }
        
        
        private void CloseAllPanels()
        {
            if (reportExpanded)
            {
                reportExpanded = false;
                reportpnl.Height = PANEL_COLLAPSED_HEIGHT;
                ReportTimer.Stop();
            }

            if (employeeExpanded)
            {
                employeeExpanded = false;
                pnlEmployee.Height = PANEL_COLLAPSED_HEIGHT;
                EmployeeTimer.Stop();
            }

            if (productExpanded)
            {
                productExpanded = false;
                Productpnl.Height = PANEL_COLLAPSED_HEIGHT;
                ProductTimer.Stop();
            }

            if (salesExpanded)
            {
                salesExpanded = false;
                Salepnl.Height = PANEL_COLLAPSED_HEIGHT;
                SalesTimer.Stop();
            }

            RepositionPanels();
        }
        
        private void Admin_Main_Home_Load(object sender, EventArgs e)
        {
            
            CloseAllPanels();
        }
        
        
        private void RepositionPanels()
        {
            int currentY = 2;
            
            
            pnlEmployee.Location = new Point(pnlEmployee.Location.X, currentY);
            currentY += pnlEmployee.Height + 2;
            
            Productpnl.Location = new Point(Productpnl.Location.X, currentY);
            currentY += Productpnl.Height + 2;
            
            Salepnl.Location = new Point(Salepnl.Location.X, currentY);
            currentY += Salepnl.Height + 2;
            
            reportpnl.Location = new Point(reportpnl.Location.X, currentY);
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            if (employeeExpanded == false)
            {
                CloseAllPanels();
                employeeExpanded = false;
                EmployeeTimer.Start();
            }
            else
            {
                employeeExpanded = true;
                EmployeeTimer.Start();
            }
        }
        
        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (productExpanded == false)
            {
                CloseAllPanels();
                productExpanded = false;
                ProductTimer.Start();
            }
            else
            {
                productExpanded = true;
                ProductTimer.Start();
            }
        }
        
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (reportExpanded == false)
            {
                CloseAllPanels();
                reportExpanded = false;
                ReportTimer.Start();
            }
            else
            {
                reportExpanded = true;
                ReportTimer.Start();
            }
        }

        
        private void btnsales_Click(object sender, EventArgs e)
        {
            if (salesExpanded == false)
            {
                CloseAllPanels();
                salesExpanded = false;
                SalesTimer.Start();
            }
            else
            {
                salesExpanded = true;
                SalesTimer.Start();
            }
        }

        
        private void btnReport_Click(object sender, EventArgs e)
        {
            
            featurePanel.Controls.Clear();
            
            try
            {
                
                Type aboutType = Type.GetType("App.UI_Forms.Manager.About");
                if (aboutType != null)
                {
                    
                    Form aboutForm = Activator.CreateInstance(aboutType) as Form;
                    if (aboutForm != null)
                    {
                        
                        aboutForm.FormBorderStyle = FormBorderStyle.None;
                        aboutForm.TopLevel = false;
                        aboutForm.Dock = DockStyle.Fill;
                        
                        
                        featurePanel.Controls.Add(aboutForm);
                        aboutForm.Show();
                        return;
                    }
                }
                
                aboutType = Type.GetType("App.UI_Forms.Admin.About");
                if (aboutType != null)
                {
                    
                    Form aboutForm = Activator.CreateInstance(aboutType) as Form;
                    if (aboutForm != null)
                    {
                        
                        aboutForm.FormBorderStyle = FormBorderStyle.None;
                        aboutForm.TopLevel = false;
                        aboutForm.Dock = DockStyle.Fill;
                        
                        
                        featurePanel.Controls.Add(aboutForm);
                        aboutForm.Show();
                        return;
                    }
                }
                
                
                MessageBox.Show("About information will be implemented soon.", 
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("About information could not be displayed: " + ex.Message, 
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information button clicked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            if (sideContainerFullHeight == 0)
            {
                sideContainerFullHeight = SideContainer.Height;
            }

           
            if (sideContainerExpanded == false)
            {
                
                SideContainer.Visible = true;
                SideContainer.Height = 0;
                CloseAllPanels();
                btnContainer.Start();
            }
            else
            {
                
                btnContainer.Start();
            }
        }

       
        private void btnContainer_Tick(object sender, EventArgs e)
        {
            if (sideContainerExpanded == false)
            {
                
                SideContainer.Height += 5;
                if (SideContainer.Height >= sideContainerFullHeight)
                {
                    SideContainer.Height = sideContainerFullHeight; 
                    sideContainerExpanded = true;
                    btnContainer.Stop();
                }
            }
            else
            {
                
                SideContainer.Height -= 5;
                if (SideContainer.Height <= 0)
                {
                    SideContainer.Height = 0; 
                    sideContainerExpanded = false;
                    SideContainer.Visible = false;
                    btnContainer.Stop();
                }
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        
        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
        
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
           
      
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e) { }
        private void panelTop_Paint(object sender, PaintEventArgs e) { }
        private void SideContainer_Paint_1(object sender, PaintEventArgs e) { }
        private void FeatureHolder_Paint(object sender, PaintEventArgs e) { }

        private void home1_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
        }

        private void addEmployee1_Load(object sender, EventArgs e)
        {
            addEmployee1.Visible = false;
        }

        private void product1_Load(object sender, EventArgs e)
        {
            product1.Visible = false;
        }

        private void employeesSearch_Load(object sender, EventArgs e)
        {
            employeesSearch.Visible = false;
        }
        private void addProduct1_Load(object sender, EventArgs e)
        {
            addProduct1.Visible = false;
        }



        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employeesSearch.Visible = false;
            addProduct1.Visible = false;
            product1.Visible = false;
            home1.Visible = false;

            addEmployee1.Visible = true;
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            employeesSearch.Visible = false;
            product1.Visible = false;
            home1.Visible = false;
            addEmployee1.Visible = false;

            addProduct1.Visible = true;
        }


        private void btnManageEmployee_Click_1(object sender, EventArgs e)
        {
            addProduct1.Visible = false;
            product1.Visible = false;
            home1.Visible = false;
            addEmployee1.Visible = false;

            employeesSearch.Visible = true;
        }

        private void btnManageProduct_Click_1(object sender, EventArgs e)
        {
            addProduct1.Visible = false;
            product1.Visible = false;
            home1.Visible = false;
            addEmployee1.Visible = false;
            employeesSearch.Visible = false;

            product1.Visible = true;
        }


    }
}
