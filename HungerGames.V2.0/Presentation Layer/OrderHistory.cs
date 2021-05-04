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
    public partial class OrderHistory : Form
    {
        private object cmd;
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard a = new Admin_Dashboard();
            a.Show();
        }

        private void storagebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Orders;";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            dataGridView1.DataSource = ds.Tables["Orders"].DefaultView;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "SELECT SUM(Price) FROM Orders WHERE Month = '" + dateTimePicker1.Text + "';";

            SqlCommand cmd = new SqlCommand(query, connection);
            int mySum = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Revenue For The day: " + mySum.ToString());
        }
    }
}
