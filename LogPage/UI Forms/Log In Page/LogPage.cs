//using App.Configuration;
using App.UI_Forms.Admin;
using App.UI_Forms.SalesMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace App
{    public partial class LogPage : Form
    {

        public LogPage()
        {
            InitializeComponent();
        }
       
        string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";               

        private void login()
        {
            string email = emailTxt.Text.Trim();
            string password = passTxt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT UserID, UserName, Role FROM Employees WHERE Email = '" + email + "' AND Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];

                int userId = Convert.ToInt32(row["UserID"]);
                string userName = row["UserName"].ToString();
                string role = row["Role"].ToString();

                MessageBox.Show("Login Successful! Welcome " + userName);

                Form nextForm = null;

                if (role == "Admin")
                {
                    nextForm = new App.UI_Forms.Admin.Admin_Main_Home();
                }
                else if (role == "Manager")
                {
                    nextForm = new Manager_Home(userId);
                }
                else if (role == "Cashier")
                {
                    nextForm = new mainCashier(userName);
                    //mainCashier cashierForm = new mainCashier(userName);
                    mainCashier cashier = new mainCashier(userName);
                }
              
                else if (role == "Salesman")
                {
                    nextForm = new Salesman();
                    Session.EmployeeId = userId;
                    Session.EmployeeName = userName;
                }
                else
                {
                    MessageBox.Show("Role not recognized. Contact admin.");
                    con.Close();
                    return;
                }

                con.Close();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password.");
                con.Close();
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            login();
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration homeForm = new Registration();           
            homeForm.Show();
            this.Hide();
        }

        private void fPassBtn_Click(object sender, EventArgs e)
        {

            ForgetPass homeForm = new ForgetPass();           
            homeForm.Show();
            this.Hide();
        }

        private void uNameTxt_TextChanged(object sender, EventArgs e){  }
        private void uNameBtn_Click(object sender, EventArgs e) {  }
        private void textBox1_TextChanged(object sender, EventArgs e) {  }
        private void textBox1_TextChanged_1(object sender, EventArgs e)  {  }
        private void panel1_Paint(object sender, PaintEventArgs e) { }   
        private void passBtn_Click(object sender, EventArgs e)  {  }
        private void passTxt_TextChanged(object sender, EventArgs e) { }
        private void messageTxt_TextChanged(object sender, EventArgs e) { }
        private void welcomeTxt_TextChanged(object sender, EventArgs e) { }
    }
}
