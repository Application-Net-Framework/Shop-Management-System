using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class tarminationForm : UserControl
    {
        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public tarminationForm()
        {
            InitializeComponent();
            LoadDatabase();
        }

        private void tarminationbtn_Click(object sender, EventArgs e)
        {

        }
        public void LoadDatabase()
        {
            try
            {
                string activeEmployees = "SELECT ID,UserName,Role FROM TARMINATION WHERE AccountStatus = 'ACTIVE'";
                string inactiveEmployees = "SELECT ID,UserName,Role FROM TARMINATION WHERE AccountStatus = 'INACTIVE'";
                    
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlDataAdapter sda1 = new SqlDataAdapter(activeEmployees, connection))
                    using(SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt1 = new DataTable();
                        DataTable dt2 = new DataTable();

                        sda1.Fill(dt1);
                        sda2.Fill(dt2);

                        if(EmployeeData != null)
                            EmployeeData.DataSource = dt1;
                            
                        if(TarminationEmployee != null)
                            TarminationEmployee.DataSource = dt2;
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void undobtn_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TarminationEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tarminationpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
