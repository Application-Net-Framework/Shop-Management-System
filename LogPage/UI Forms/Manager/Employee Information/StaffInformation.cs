using App.UI_Forms.Manager.Employee_Information;
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
    public partial class StaffInformation : Form
    {
        public StaffInformation()
        {
            InitializeComponent();
            
            // Initialize form properties to ensure designer compatibility
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        // Method to populate form fields with employee data
        public void PopulateEmployeeDetails(database employee)
        {
            if (employee != null)
            {
                try
                {
                    // Populate all the form fields
                    txtuserid.Text = employee.userId.ToString();
                    txtusrname.Text = employee.userName ?? string.Empty;
                    txtgender.Text = employee.gender ?? string.Empty;
                    txtphone.Text = employee.phone ?? string.Empty;
                    dateofbirthtxt.Value = employee.DOB;
                    txtage.Text = employee.age.ToString();
                    txtrole.Text = employee.Role ?? string.Empty;
                    hiredate.Value = employee.hireDate;
                    textBox1.Text = employee.Degree ?? string.Empty; // This is the Degree field
                    
                    // Populate the comboboxes if they are for displaying employee data
                    if (!string.IsNullOrEmpty(employee.Role))
                    {
                        comboBox1.Text = employee.Role; // Role combobox
                    }
                    if (!string.IsNullOrEmpty(employee.Assignby))
                    {
                        comboBox2.Text = employee.Assignby; // Assignby combobox
                    }
                    
                    // Hide the search container after selection
                    searchContainer.Height = 0;
                    searchContainer.Visible = false;
                    
                    // Clear the search box
                    searchbox.Text = string.Empty;
                    
                    System.Diagnostics.Debug.WriteLine($"Successfully populated form with employee data: {employee.userName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error populating employee details: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine($"Error populating form: {ex.Message}");
                }
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            searchContainer.Controls.Clear();
            
            if (searchbox.TextLength >= 1)
            {
                try
                {
                    // Debug output
                    System.Diagnostics.Debug.WriteLine($"Searching for: '{searchbox.Text}'");
                    
                    // Perform search
                    database db = new database();
                    db.search(searchbox.Text);
                    
                    // Debug: Check if search returned results
                    System.Diagnostics.Debug.WriteLine($"Search returned {database.list.Count} results");
                    
                    // Debug: Show what data we got from database
                    for (int i = 0; i < database.list.Count; i++)
                    {
                        var item = database.list[i];
                        System.Diagnostics.Debug.WriteLine($"Result {i}: UserID={item.userId}, UserName='{item.userName ?? "NULL"}', Phone='{item.phone ?? "NULL"}', Gender='{item.gender ?? "NULL"}'");
                    }
                    
                    // Load search results
                    loadDetails();
                    
                    // Adjust container height based on number of results
                    if (database.list.Count > 0)
                    {
                        searchContainer.Height = Math.Max(70, database.list.Count * 70);
                        searchContainer.Visible = true;
                    }
                    else
                    {
                        searchContainer.Height = 50;
                        searchContainer.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Search error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                }
            }
            else
            {
                searchContainer.Height = 0;
                searchContainer.Visible = false;
            }
        }

        private void searchlbl_Click(object sender, EventArgs e)
        {
            // Focus on search box when label is clicked
            searchbox.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Trigger search when picture box is clicked
            if (!string.IsNullOrEmpty(searchbox.Text))
            {
                searchbox_TextChanged(searchbox, EventArgs.Empty);
            }
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {
            // Initialize search container
            searchContainer.Height = 0;
            searchContainer.AutoScroll = true;
            searchContainer.Visible = false;
            
            // Set search container properties for better display
            searchContainer.FlowDirection = FlowDirection.TopDown;
            searchContainer.WrapContents = false;
            
            // Test database connection
            try
            {
                database testDb = new database();
                if (testDb.TestConnection())
                {
                    System.Diagnostics.Debug.WriteLine("Database connection successful!");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Database connection failed!");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database connection error: {ex.Message}");
            }
        }
        
        private void loadDetails()
        {
            // Clear existing controls
            searchContainer.Controls.Clear();
            
            System.Diagnostics.Debug.WriteLine($"loadDetails() called with {database.list.Count} items");
            
            // Add a control for each search result
            foreach (database data in database.list)
            {
                SearchResultControl src = new SearchResultControl();
                
                // Debug: Check what data is being passed BEFORE calling details
                System.Diagnostics.Debug.WriteLine($"BEFORE calling details - UserName: '{data.userName ?? "NULL"}', Phone: '{data.phone ?? "NULL"}'");
                
                src.details(data);
                src.Width = searchContainer.Width - 10; // Leave some margin
                src.Height = 65; // Fixed height for each result
                src.Margin = new Padding(2);
                src.BorderStyle = BorderStyle.FixedSingle; // Add border for visibility
                
                // Set up click event to populate the form
                src.Click += (sender, e) => PopulateEmployeeDetails(data);
                src.Tag = data; // Store the employee data in the Tag property
                
                // Debug: Check what data is being passed AFTER calling details
                System.Diagnostics.Debug.WriteLine($"AFTER calling details - Adding result control for: '{data.userName ?? "NULL"}' - '{data.phone ?? "NULL"}'");
                
                searchContainer.Controls.Add(src);
            }
            
            // Show message if no results found
            if (database.list.Count == 0 && !string.IsNullOrEmpty(searchbox.Text))
            {
                Label noResultsLabel = new Label
                {
                    Text = $"No employees found matching '{searchbox.Text}'",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    AutoSize = false,
                    Width = searchContainer.Width - 10,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };
                searchContainer.Controls.Add(noResultsLabel);
            }
            
            System.Diagnostics.Debug.WriteLine($"loadDetails() completed. Added {searchContainer.Controls.Count} controls to searchContainer");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void informationContainerpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
