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

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class newRegistrationEmployees : UserControl
    {
        public string totalCashier;
        public string totalManager;
        public string totalSalesman;
        public string totalNewEmployee;

        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public newRegistrationEmployees()
        {
            InitializeComponent();
            LoadDatabse();
            LoadMemberCount();

            cashierEmpLb.Text = totalCashier;
            managerAmountlb.Text = totalManager;
            salemanLb.Text = totalSalesman;
            // totalNewEmployeelb.Text = totalNewEmployee;

        }
        public void DataGridviewDesign()
        {
            NewEmployee.DataSource = null;
            
        }
        public void LoadMemberCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string ManagerCounter = "SELECT COUNT(*) FROM EMPLOYEE WHERE ROLE = 'Manager'";
                    string CashierCounter = "SELECT COUNT(*) FROM EMPLOYEE WHERE ROLE = 'Cashier'";
                    string SalesmanCounter = "SELECT COUNT(*) FROM EMPLOYEE WHERE ROLE = 'SalesMan'";

                    connection.Open();
                    SqlCommand commandManager = new SqlCommand(ManagerCounter, connection);
                    SqlCommand commandCashier = new SqlCommand(CashierCounter, connection);
                    SqlCommand commandSalesman = new SqlCommand(SalesmanCounter, connection);

                    SqlDataReader readerManager = commandManager.ExecuteReader();
                    if (readerManager.Read())
                    {
                        totalManager = readerManager.IsDBNull(0) ? "0" : readerManager.GetInt32(0).ToString();
                    }
                    readerManager.Close();

                    SqlDataReader readerCashier = commandCashier.ExecuteReader();
                    if (readerCashier.Read())
                    {
                        totalCashier = readerCashier.IsDBNull(0) ? "0" : readerCashier.GetInt32(0).ToString();
                    }
                    readerCashier.Close();

                    SqlDataReader readerSalesman = commandSalesman.ExecuteReader();
                    if (readerSalesman.Read())
                    {
                        totalSalesman = readerSalesman.IsDBNull(0) ? "0" : readerSalesman.GetInt32(0).ToString();
                    }
                    readerSalesman.Close();

                    totalNewEmployee = (int.Parse(totalCashier) + int.Parse(totalManager) + int.Parse(totalSalesman)).ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDatabse()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM EMPLOYEE WHERE PHONENUMBER IS NULL OR EMAIL IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            NewEmployee.DataSource = dt;
                        }
                        else
                        {
                            DataGridviewDesign();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void NewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newEmployeText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Employee WHERE AccountStatus = 'active' AND (CAST(userID AS NVARCHAR) LIKE @Search OR userName LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        NewEmployee.DataSource = null;

                        cmd.Parameters.AddWithValue("@Search", "%" + newEmployeText.Text + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            NewEmployee.DataSource = dt;

                        }
                        else
                        {
                            DataGridviewDesign();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }
        // Refresh Button
        private void undobtn_Click(object sender, EventArgs e)
        {
            LoadDatabse();
            LoadMemberCount();
        }
    }
}


