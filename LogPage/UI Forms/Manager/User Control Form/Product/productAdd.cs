using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class productAdd : UserControl
    {
        public int counter = 0;
        public string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        public productAdd()
        {
            InitializeComponent();

            plusbtn.Text = "+";
            plusbtn.ForeColor = Color.Red;

            minusbtn.Text = "-";
            minusbtn.ForeColor = Color.Red;

            string converter = counter.ToString();
            quantitytxt.Text = converter;

            quantitytxt.KeyPress += new KeyPressEventHandler(quantitytxt_KeyPress);
           loadDatabase();
        }
        public void loadDatabase()
        {
            try
            {
                string inactiveEmployees = "SELECT * FROM Product";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);

                        if (productAddDatabase != null)
                            productAddDatabase.DataSource = dt2;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }

        }
        private void stacklevelbtn1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            counter++;
            string converter = counter.ToString();
            quantitytxt.Text = converter;
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = 0;
            }
            string converter = counter.ToString();
            quantitytxt.Text = converter;
        }

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if (quantitytxt.Text != "")
            {
                counter = Convert.ToInt32(quantitytxt.Text);
            }
            else
            {
                counter = 0;
                quantitytxt.Text = "";
            }
        }

       
            private void addbtn_Click(object sender, EventArgs e){
            try
            {
                
                string name = productNametxt.Text;
                string category = catagoryNametxt.Text;        
                int stock = counter;                        
                string description = descriptiontxt.Text;
                decimal price;

                
                if (!decimal.TryParse(pricetxt.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime expiry = expiredate.Value;

                
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || stock <= 0)
                {
                    MessageBox.Show("Please fill all required fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Product (ProductName, CategoryName, Stock, Price, Description, ExpiryDate) " +
                                   "VALUES (@name, @category, @stock, @price, @desc, @expiry)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@expiry", expiry);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                productNametxt.Clear();
               
                descriptiontxt.Clear();
                pricetxt.Clear();
                counter = 0;
                quantitytxt.Text = "0";

              
                loadDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

