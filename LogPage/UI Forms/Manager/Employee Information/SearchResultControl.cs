using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.Employee_Information
{
    public partial class SearchResultControl : UserControl
    {
        private App.UI_Forms.Manager.database employeeData;
        
        public SearchResultControl()
        {
            InitializeComponent();
            
            // Set default text to help with debugging
            usernamelb.Text = "Loading...";
            phonelb.Text = "Loading...";
            
            // Make the entire control clickable
            this.Cursor = Cursors.Hand;
        }

        private void SearchResultControl_Load(object sender, EventArgs e)
        {
            // Ensure all child controls forward their click events to the parent
            foreach (Control control in this.Controls)
            {
                control.Click += (s, args) => this.OnClick(args);
                control.Cursor = Cursors.Hand;
            }
        }
        
        // Method to populate the control with employee data
        public void details(App.UI_Forms.Manager.database d)
        {
            if (d != null)
            {
                employeeData = d;
                
                // Debug: Show what data we're receiving
                string debugInfo = $"UserID: {d.userId}, UserName: '{d.userName}', Phone: '{d.phone}'";
                System.Diagnostics.Debug.WriteLine(debugInfo);

                // Set the text with fallback values
                usernamelb.Text = d.userName ?? "No Name";
                phonelb.Text = d.phone ?? "No Phone";
                
                // Force refresh
                usernamelb.Refresh();
                phonelb.Refresh();
                this.Refresh();
            }
            else
            {
                usernamelb.Text = "No Data";
                phonelb.Text = "No Data";
            }
        }
        
        // Method to display search results
        public void SearchResult(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                usernamelb.Text = "Enter search term";
                phonelb.Text = "";
                return;
            }
            
            App.UI_Forms.Manager.database db = new App.UI_Forms.Manager.database();
            db.search(key);
            
            // Display the first result if any found
            if (App.UI_Forms.Manager.database.list.Count > 0)
            {
                var firstResult = App.UI_Forms.Manager.database.list[0];
                details(firstResult);
            }
            else
            {
                usernamelb.Text = "No results found";
                phonelb.Text = "";
            }
        }
        
        // Property to get the current employee data
        public App.UI_Forms.Manager.database EmployeeData
        {
            get { return employeeData; }
        }
        
        // Method to clear the display
        public void ClearDisplay()
        {
            usernamelb.Text = "Complete Name";
            phonelb.Text = "Phone";
            employeeData = null;
        }

        private void usernamelb_Click(object sender, EventArgs e)
        {
            // Forward the click to the parent control
            this.OnClick(e);
        }

        private void phonelb_Click(object sender, EventArgs e)
        {
            // Forward the click to the parent control
            this.OnClick(e);
        }
        
        // Override the OnClick method to handle the auto-population
        protected override void OnClick(EventArgs e)
        {
            if (employeeData != null)
            {
                // Find the parent StaffInformation form
                var staffForm = this.FindForm() as App.UI_Forms.Manager.StaffInformation;
                if (staffForm != null)
                {
                    // Call the populate method
                    staffForm.PopulateEmployeeDetails(employeeData);
                    System.Diagnostics.Debug.WriteLine($"Clicked on employee: {employeeData.userName}");
                }
            }
            
            base.OnClick(e);
        }
    }
}
