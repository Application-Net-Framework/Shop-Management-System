using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace App
{
   
    public partial class LogPage : Form
    {
        public string Password = "12345";
        public string username;

        public LogPage()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {          
            string inputUsername = uNameTxt.Text.Trim();
            string inputPassword = passTxt.Text.Trim();

          
            if (inputPassword != Password)
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }                 
                     
            if (inputUsername.EndsWith(".admin"))
            {
                MessageBox.Show("Successfully login as Admin!");
                Admin_Home  A = new Admin_Home();
                
                A.Show();
                this.Hide();
                

            }
            else if (inputUsername.EndsWith(".manager"))
            {
                MessageBox.Show("Successfully login as Manager!");
                Manager_Home M = new Manager_Home();
                M.Show();
                this.Hide();
                
            }
            else if (inputUsername.EndsWith(".cashier"))
            {
                MessageBox.Show("Successfully login as Cashier!");
                Cashier_Home C = new Cashier_Home();
                C.Show();
                this.Hide();
                
            }
            else if (inputUsername.EndsWith(".salesman"))
            {
                MessageBox.Show("Successfully login as Salesman!");
                SalesMan_Home S = new SalesMan_Home();
                S.Show();
                this.Hide();
               

            }
            else
            {
                MessageBox.Show("Successfully login");
            }
          
        }
       

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register homeForm = new Register();
            homeForm.Show();
            this.Hide();
        }

        private void fPassBtn_Click(object sender, EventArgs e)
        {

            ForgetPass homeForm = new ForgetPass();
            homeForm.Show();
            this.Hide();
        }

        private void uNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void uNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passBtn_Click(object sender, EventArgs e)
        {

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void messageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
        // table Name:Login,column1:UserName,column2:Password  
        // connect your bd and make table and column name as above

        private void logBtn_Click(object sender, EventArgs e)
        {
            
            string inputUsername = uNameTxt.Text.Trim();
            string inputPassword = passTxt.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // This portion of code will vary based on your database setup
            string connectionString = "Data Source=DESKTOP-ESC3M7E\\SQLEXPRESS;Initial Catalog=appdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            
            string dbPassword = null;

          
            string sqlQuery = "SELECT Password FROM Login WHERE UserName = @username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {            
                        command.Parameters.AddWithValue("@username", inputUsername);
                        connection.Open();                        
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            
                            dbPassword = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {                
                Console.WriteLine("DB Error: " + ex.Message);
                MessageBox.Show("An error occurred while connecting to the database.");
                return;
            }

            
            if (inputPassword == dbPassword)
            {               
                if (inputUsername.EndsWith(".admin"))
                {
                    MessageBox.Show("Login Successful as Admin!");
                    Admin_Home admin = new Admin_Home();
                    admin.Show();
                    this.Hide();
                }
                else if (inputUsername.EndsWith(".manager"))
                {
                    MessageBox.Show("Login Successful as Manager!");
                    Manager_Home manager = new Manager_Home();
                    manager.Show();
                    this.Hide();
                }
                else if (inputUsername.EndsWith(".cashier"))
                {
                    MessageBox.Show("Login Successful as cashier!");
                    Cashier_Home cashier = new Cashier_Home();
                    cashier.Show();
                    this.Hide();
                }
                else if (inputUsername.EndsWith(".salesman"))
                {
                    MessageBox.Show("Login Successful as SalesMan!");
                    SalesMan_Home SalesMan = new SalesMan_Home();
                    SalesMan.Show();
                    this.Hide();
                }               
                else
                {
                    MessageBox.Show("Login Successful!");
                    
                }
            }

            else
            {
             
                MessageBox.Show("Invalid username or password!");
            }
        }  
    
        */