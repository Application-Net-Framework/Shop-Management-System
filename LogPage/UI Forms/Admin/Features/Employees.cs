using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;





namespace App.UI_Forms.Admin
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                MessageBox.Show("Please select a row first:");
            else
            {
                string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "DELETE FROM Employees WHERE UserID=" + txtID.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                show();
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE Employees " +
                           "SET UserName='" + txtName.Text +
                           "', Email='" + txtEmail.Text +
                           "', PhoneNumber='" + txtNumber.Text +
                           "' WHERE UserID=" + txtID.Text;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conne = new SqlConnection(connectionString);
            conne.Open();
            string quarry = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(quarry, conne);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            show();
            clear();
        }

        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conne = new SqlConnection(connectionString);
            conne.Open();
            string quarry = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(quarry, conne);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = boxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                show();
                return;
            }

            
            //string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Employees 
                                 WHERE UserName LIKE @SearchText 
                                 OR Email LIKE @SearchText 
                                 OR PhoneNumber LIKE @SearchText 
                                 OR UserName LIKE @SearchText 
                                 OR CAST(UserID AS NVARCHAR) LIKE @SearchText";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


