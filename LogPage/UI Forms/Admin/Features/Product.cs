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
using System.Xml.Linq;

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
            txtPID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAProduct.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTProduct.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conne = new SqlConnection(connectionString);
            conne.Open();
            string quarry = "SELECT * FROM AddEmployee";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE AddEmployee " +
               "SET Name='" + txtPName.Text +
               "', Email='" + txtEmail.Text +
               "', Phone_Number='" + txtNumber.Text +
               "' WHERE ID=" + txtID.Text;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "")
                MessageBox.Show("Please select a row first:");
            else
            {
                string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from AddEmployee where ID=" + txtPID.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                show();
                clear();
            }
        }

        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-HRPRSI4\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection conne = new SqlConnection(connectionString);
            conne.Open();
            string quarry = "SELECT * FROM AddEmployee";
            SqlCommand cmd = new SqlCommand(quarry, conne);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";
            txtAProduct.Text = "";
            txtTProduct.Text = "";
        }

    }
}
