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

namespace App.UI_Forms.Manager
{
    public partial class StaffInformation : Form
    {
        public StaffInformation()
        {
            InitializeComponent();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=siamDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Application Intent=ReadWrite;Multi SubnetFailover=False";

            string query = "SELECT * FROM staffinfo " +
                           "WHERE CAST(ID AS VARCHAR) LIKE @searchbox " +
                           "OR Name LIKE @searchbox " +
                           "OR Mail LIKE @searchbox";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchbox", "%" + searchbox.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    staffinfo.DataSource = dataTable;
                }
            }
        }

    }
}
