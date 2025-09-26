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

        // Panel expansion states
        bool reportExpanded = false;
        bool employeeExpanded = false;
        bool productExpanded = false;
        bool salesExpanded = false;
        
        // SideContainer animation variables
        private bool sideContainerExpanded = true; // Start expanded
        private int sideContainerFullHeight;

        public Admin_Main_Home()
        {
            InitializeComponent();

            // Set form size
            this.Size = new Size(900, 600);
            this.ClientSize = new Size(900, 600);
            
            // Remove size constraints
            this.MaximumSize = new Size(0, 0);
            this.MinimumSize = new Size(0, 0);

            // Initialize panels
            reportpnl.Height = PANEL_COLLAPSED_HEIGHT;
            pnlEmployee.Height = PANEL_COLLAPSED_HEIGHT;
            Productpnl.Height = PANEL_COLLAPSED_HEIGHT;
            Salepnl.Height = PANEL_COLLAPSED_HEIGHT;

            // Add panels to SideContainer
            SideContainer.Controls.Add(pnlEmployee);
            SideContainer.Controls.Add(Productpnl);
            SideContainer.Controls.Add(Salepnl);
            SideContainer.Controls.Add(reportpnl);
            
            // Store the original SideContainer height
            sideContainerFullHeight = SideContainer.Height;

            // Configure animation timer - match the pattern of other timers
            btnContainer.Interval = 10;
            btnContainer.Tick += btnContainer_Tick;

            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Position panels initially
            RepositionPanels();
            
            // Start with SideContainer hidden
            sideContainerExpanded = false;
            SideContainer.Visible = false;
        }
        
        // Employee panel timer
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
        
        // Report panel timer
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
        
        // Product panel timer
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
        
        // Sales panel timer
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
        
        // Helper method to close all panels
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
            // Ensure all panels are in proper initial state
            CloseAllPanels();
        }
        
        // Method to reposition panels based on their current state
        private void RepositionPanels()
        {
            int currentY = 2;
            
            // Position each panel in sequence
            pnlEmployee.Location = new Point(pnlEmployee.Location.X, currentY);
            currentY += pnlEmployee.Height + 2;
            
            Productpnl.Location = new Point(Productpnl.Location.X, currentY);
            currentY += Productpnl.Height + 2;
            
            Salepnl.Location = new Point(Salepnl.Location.X, currentY);
            currentY += Salepnl.Height + 2;
            
            reportpnl.Location = new Point(reportpnl.Location.X, currentY);
        }

        // Log Out button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Employee panel button
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
        
        // Product panel button
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
        // Settings button
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

        // Sales/Report panel button
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

        // Admin Info button about btn
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Clear the feature panel
            featurePanel.Controls.Clear();
            
            try
            {
                // Try to find the About form in the Manager namespace first
                Type aboutType = Type.GetType("App.UI_Forms.Manager.About");
                if (aboutType != null)
                {
                    // Create an instance of the About form
                    Form aboutForm = Activator.CreateInstance(aboutType) as Form;
                    if (aboutForm != null)
                    {
                        // Remove its border to make it look like a user control
                        aboutForm.FormBorderStyle = FormBorderStyle.None;
                        aboutForm.TopLevel = false;
                        aboutForm.Dock = DockStyle.Fill;
                        
                        // Add it to the feature panel and show it
                        featurePanel.Controls.Add(aboutForm);
                        aboutForm.Show();
                        return;
                    }
                }
                
                // Try to find the About form in the Admin namespace as fallback
                aboutType = Type.GetType("App.UI_Forms.Admin.About");
                if (aboutType != null)
                {
                    // Create an instance of the About form
                    Form aboutForm = Activator.CreateInstance(aboutType) as Form;
                    if (aboutForm != null)
                    {
                        // Remove its border to make it look like a user control
                        aboutForm.FormBorderStyle = FormBorderStyle.None;
                        aboutForm.TopLevel = false;
                        aboutForm.Dock = DockStyle.Fill;
                        
                        // Add it to the feature panel and show it
                        featurePanel.Controls.Add(aboutForm);
                        aboutForm.Show();
                        return;
                    }
                }
                
                // If we couldn't find or create the About form, show a message
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

        // Toggle sidebar visibility with animation
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Store full height if not already set
            if (sideContainerFullHeight == 0)
            {
                sideContainerFullHeight = SideContainer.Height;
            }

            // Toggle expanded state with the same pattern as your other animations
            if (sideContainerExpanded == false)
            {
                // Make it visible with zero height to start animation
                SideContainer.Visible = true;
                SideContainer.Height = 0;
                CloseAllPanels();
                btnContainer.Start();
            }
            else
            {
                // Start collapsing animation
                btnContainer.Start();
            }
        }

        // SideContainer animation timer
        private void btnContainer_Tick(object sender, EventArgs e)
        {
            if (sideContainerExpanded == false)
            {
                // Expanding - increase height by pixels per tick
                SideContainer.Height += 5;
                if (SideContainer.Height >= sideContainerFullHeight)
                {
                    SideContainer.Height = sideContainerFullHeight; // Ensure exact height
                    sideContainerExpanded = true;
                    btnContainer.Stop();
                }
            }
            else
            {
                // Collapsing - decrease height by pixels per tick
                SideContainer.Height -= 5;
                if (SideContainer.Height <= 0)
                {
                    SideContainer.Height = 0; // Ensure exact height
                    sideContainerExpanded = false;
                    SideContainer.Visible = false;
                    btnContainer.Stop();
                }
            }
        }
        
        // Functionality buttons for Employee
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        // Button click handlers for the AdminMainHome form
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
            // Clear the feature panel
      
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {

        }

        // Form event handlers
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
