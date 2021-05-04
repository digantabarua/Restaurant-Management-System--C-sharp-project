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
    public partial class WaiterMenu : Form
    {
        public WaiterMenu()
        {
            InitializeComponent();
        }

        private void WaiterMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Menu;";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            dataGridView1.DataSource = ds.Tables["Menu"].DefaultView;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
            employee_Dashboard.Show();
        }
    }
}
