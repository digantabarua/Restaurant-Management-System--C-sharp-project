using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungerGames.V2._0.Presentation_Layer
{
    public partial class WaiterStorage : Form
    {
        public WaiterStorage()
        {
            InitializeComponent();
        }

        private void WaiterStorage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void storagebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Storages;";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Storages");
            dataGridView1.DataSource = ds.Tables["Storages"].DefaultView;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
            employee_Dashboard.Show();
        }
    }
}
