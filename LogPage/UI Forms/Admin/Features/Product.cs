using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App.UI_Forms.Admin
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtPID.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtPName.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            show();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Product SET ProductName=@ProductName, Price=@Price, CategoryName=@CategoryName WHERE ProductID=@ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", txtPName.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@CategoryName", txtCategory.Text);
                cmd.Parameters.AddWithValue("@ProductID", txtPID.Text);
                cmd.ExecuteNonQuery();
            }
            show();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "")
            {
                MessageBox.Show("Please select a row first:");
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Product WHERE ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", txtPID.Text);
                    cmd.ExecuteNonQuery();
                }
                show();
                clear();
            }
        }

        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            using (SqlConnection conne = new SqlConnection(connectionString))
            {
                conne.Open();
                string quarry = "SELECT ProductID, ProductName, Price, CategoryName FROM Product";
                SqlCommand cmd = new SqlCommand(quarry, conne);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
            }
        }

        private void clear()
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";
            
        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void boxSearchproduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = boxSearchproduct.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                show();
                return;
            }

            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT ProductID, ProductName, Price, CategoryName
                             FROM Product
                             WHERE ProductName LIKE @SearchText
                             OR CategoryName LIKE @SearchText
                             OR CAST(ProductID AS NVARCHAR(50)) LIKE @SearchText
                             OR CAST(Price AS NVARCHAR(50)) LIKE @SearchText";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SearchText", SqlDbType.NVarChar).Value = "%" + searchText + "%";

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.AutoGenerateColumns = true;

                        if (dt.Rows.Count > 0)
                            dataGridView1.DataSource = dt;
                        else
                            dataGridView1.DataSource = null;

                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }
    }
}


