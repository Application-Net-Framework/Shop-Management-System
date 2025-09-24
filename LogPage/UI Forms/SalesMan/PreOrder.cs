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
    public partial class PreOrder : Form
    {
        public PreOrder()
        {
            InitializeComponent();
        }

        String connectionString = @"Data Source=DESKTOP-ESC3M7E\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void InsertPreOrder()
        {
            // Read & validate
            string productName = nameTxt.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Enter product name.");
                return;
            }

            if (!int.TryParse(quantityTxt.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity (positive integer).");
                return;
            }

            string mobile = mobileTxt.Text.Trim();
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Enter customer mobile.");
                return;
            }

            // Use DateTimePicker.Value (no string parsing)
            DateTime preferredDate = preferedDateTxt.Value.Date;

            // Business rule example: preferred date cannot be earlier than today
            if (preferredDate < DateTime.Today)
            {
                MessageBox.Show("Preferred date cannot be before today.");
                return;
            }

            // Insert using parameterized query and proper SqlDbType
            const string sql = @"
        INSERT INTO PreOrder (ProductName, Quantity, CustomerMobile, PreferredDate)
        VALUES (@ProductName, @Quantity, @CustomerMobile, @PreferredDate);
    ";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 100).Value = productName;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                    cmd.Parameters.Add("@CustomerMobile", SqlDbType.NVarChar, 20).Value = mobile;
                    cmd.Parameters.Add("@PreferredDate", SqlDbType.Date).Value = preferredDate; // or SqlDbType.DateTime

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pre-order submitted.");
                // optional: clear fields
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadPreOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT PreOrderID, ProductName, Quantity, CustomerMobile, DateRequested, PreferredDate FROM PreOrder";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error loading pre-orders: " + ex.Message);
                    }
                }
            }
        }



        private void preOrderBtn_Click(object sender, EventArgs e)
        {
            InsertPreOrder();
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

        private void discountBtn_Click(object sender, EventArgs e)
        {
            DiscountSuggestion DS = new DiscountSuggestion();
            DS.StartPosition = FormStartPosition.Manual;
            DS.Location = this.Location;
            DS.Size = this.Size;
            DS.Show();
            this.Hide();
        }

        private void cManagementBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement CM = new CustomerManagement();
            CM.StartPosition = FormStartPosition.Manual;
            CM.Location = this.Location;
            CM.Size = this.Size;
            CM.Show();
            this.Hide();
        }

        private void viewPreOrderbtn_Click(object sender, EventArgs e)
        {
            LoadPreOrders();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text="";
            mobileTxt.Text="";  
            quantityTxt.Text="";
            preferedDateTxt.Text = "";
        }

        private void preferedDateTxt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
