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

namespace App.UI_Forms.SalesMan
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;   // or AutoScaleMode.Font
            this.AutoSize = true;
        }

        String connectionString = GlobalConfig.ConnectionString;
        private void AddCustomer(string name, string mobile, string email, string membershipStatus)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Customer (Name, Mobile, Email, MembershipStatus) VALUES (@Name, @Mobile, @Email, @MembershipStatus)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Mobile", mobile);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@MembershipStatus", membershipStatus);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Customer added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void LoadCustomerList()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT CustomerID, Name, Mobile, Email, MembershipStatus FROM Customer";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }














        private void CustomerManagement_Load(object sender, EventArgs e)
        {
           
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman S = new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }

        private void pQueryBtn_Click(object sender, EventArgs e)
        {
            ProductQuery PQ = new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
            this.Hide();
        }

        

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogPage login = new LogPage();
            login.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCustomer(nameTxt.Text, mobileTxt.Text, emailTxt.Text, statusTxt.Text);
        }

        private void seeBtn_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            mobileTxt.Text = "";
            emailTxt.Text = "";
            statusTxt.Text = "";
        }

        private void benifitBtn_Click(object sender, EventArgs e)
        {
            string benefits = "Regular Membership:\n" +
                      "1. Basic Access to Services\n" +
                      "2. Cost-Effective\n\n" +
                      "Premium Membership:\n" +
                      "1. Priority Support and Exclusive Features\n" +
                      "2. Enhanced Flexibility and Perks";

            MessageBox.Show(benefits, "Membership Benefits", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            PreOrder PO = new PreOrder();
            PO.StartPosition = FormStartPosition.Manual;
            PO.Location = this.Location;
            PO.Size = this.Size;
            PO.Show();
            this.Hide();
        }
    }
}
