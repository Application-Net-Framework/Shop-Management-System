using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UI_Forms.Manager
{
    public class database
    {
        private string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=\"Demo Manager\";Integrated Security=True;TrustServerCertificate=True;";
        
        // Employee properties matching EmployeeInformation table
        public int userId { get; set; }
        public string userName { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public DateTime DOB { get; set; }
        public int age { get; set; }
        public string Role { get; set; }
        public DateTime hireDate { get; set; }
        public string Degree { get; set; }
        public string Assignby { get; set; }
        public string roleby { get; set; }
        
        // Legacy properties for backward compatibility
        public string password { get; set; }
        public int id 
        { 
            get { return userId; } 
            set { userId = value; } 
        }
        public string name 
        { 
            get { return userName; } 
            set { userName = value; } 
        }
        public string mail { get; set; } // Not in database but kept for compatibility
        public string address { get; set; } // Not in database but kept for compatibility
        public string position { get; set; } // Not in database but kept for compatibility
        public string salary { get; set; } // Not in database but kept for compatibility
        
        // Static list to hold employee data
        public static List<database> list = new List<database>();
        
        // Constructor
        public database()
        {
            DOB = DateTime.Now;
            hireDate = DateTime.Now;
            age = 0;
        }
        
        // Constructor with parameters
        public database(string userName, string gender, string phone, DateTime dob, int age, string role, DateTime hireDate, string degree)
        {
            this.userName = userName;
            this.gender = gender;
            this.phone = phone;
            this.DOB = dob;
            this.age = age;
            this.Role = role;
            this.hireDate = hireDate;
            this.Degree = degree;
        }
        
        // Test database connection
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    System.Diagnostics.Debug.WriteLine("Database connection test successful!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database connection test failed: {ex.Message}");
                System.Windows.Forms.MessageBox.Show($"Connection failed: {ex.Message}", "Database Error", 
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        
        public void search(string key)
        {
            list.Clear();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    System.Diagnostics.Debug.WriteLine("Database connection opened successfully");
                    
                    string query = @"SELECT [userId], [userName], [gender], [phone], [DOB], [age], [Role], [hireDate], [Degree], [Assignby], [roleby] 
                                    FROM [Demo Manager].[dbo].[EmployeeInformation] 
                                    WHERE [userName] LIKE @key OR [phone] LIKE @key OR [userId] LIKE @key";
                    System.Diagnostics.Debug.WriteLine($"Executing query: {query}");
                    System.Diagnostics.Debug.WriteLine($"Search parameter: '%{key}%'");
                    
                    using (SqlCommand com = new SqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@key", "%" + key + "%");
                        
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            int recordCount = 0;
                            while (reader.Read())
                            {
                                recordCount++;
                                
                                // Debug: Show raw data from database
                                System.Diagnostics.Debug.WriteLine($"--- Database Record {recordCount} ---");
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string fieldName = reader.GetName(i);
                                    object fieldValue = reader.IsDBNull(i) ? "NULL" : reader.GetValue(i);
                                    System.Diagnostics.Debug.WriteLine($"  {fieldName}: '{fieldValue}'");
                                }
                                
                                database employee = new database
                                {
                                    userId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                    userName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                    gender = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                    phone = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                    DOB = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4),
                                    age = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                    Role = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                                    hireDate = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7),
                                    Degree = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                                    Assignby = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                                    roleby = reader.IsDBNull(10) ? string.Empty : reader.GetString(10)
                                };
                                
                                // Debug output AFTER creating the object
                                System.Diagnostics.Debug.WriteLine($"Created employee object: ID={employee.userId}, Name='{employee.userName}', Phone='{employee.phone}', Role='{employee.Role}'");
                                
                                list.Add(employee);
                            }
                            
                            System.Diagnostics.Debug.WriteLine($"Total records processed: {recordCount}");
                        }
                    }
                }
                
                // Debug: Show total results
                System.Diagnostics.Debug.WriteLine($"Search for '{key}' returned {list.Count} results");
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database search error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                System.Windows.Forms.MessageBox.Show($"Error searching employees: {ex.Message}", "Database Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
