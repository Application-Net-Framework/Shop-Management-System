//using App.Configuration;
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

namespace App
{
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
        }       
        string connectionString = @"Data Source=GSM\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        private void passReset()
        {
            string mobile = mobileTxt.Text.Trim();
            string dobInput = dobTxt.Text.Trim();
            string newPass = passTxt.Text.Trim();
            string rePass = checkPassTxt.Text.Trim();
            if (string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(dobInput) ||
                string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(rePass))
            {   MessageBox.Show("Please fill all fields (Mobile, DOB, New Password, Retype Password)."); return; }
            if (newPass != rePass)
            {   MessageBox.Show("Passwords do not match! Please retype correctly."); return; }
            
            DateTime dob;
            try { dob = Convert.ToDateTime(dobInput); }
            catch { MessageBox.Show("Invalid Date format. Use YYYY-MM-DD."); return; }

            string dobFormatted = dob.ToString("yyyy-MM-dd"); 
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string checkQuery = "SELECT * FROM Employees WHERE PhoneNumber = '" + mobile + "' AND DOB = '" + dobFormatted + "'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            SqlDataAdapter adp = new SqlDataAdapter(checkCmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {   string updateQuery = "UPDATE Employees SET Password = '" + newPass + "' WHERE PhoneNumber = '" + mobile + "' AND DOB = '" + dobFormatted + "'";
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {   MessageBox.Show("Password updated successfully!");
                    passTxt.Clear();
                    checkPassTxt.Clear();
                }
                else
                {MessageBox.Show("Password update failed. Try again."); }
            }
            else
            {   MessageBox.Show("Invalid Mobile or Date of Birth."); }
            con.Close();
        }         
        private void ForgetPass_Load(object sender, EventArgs e) {  }
        private void confirmBtn_Click(object sender, EventArgs e)
        { passReset();}

        private void button1_Click(object sender, EventArgs e)
        {   LogPage logPage = new LogPage();          
            logPage.Show();
            this.Hide();
        }
    }
}
