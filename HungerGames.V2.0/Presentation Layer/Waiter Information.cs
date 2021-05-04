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
    
    public partial class Waiter_Information : Form
    {
        private SqlCommand cmd;
        public Waiter_Information()
        {
            InitializeComponent();
        }

        private void Waiter_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Employees where Employeeid = ('" + textBox1.Text + "');";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            dataGridView1.DataSource = ds.Tables["Employees"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
            employee_Dashboard.Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();


            string employeeID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ColumnName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            string change = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string query = "UPDATE Employees set " + ColumnName + " = '" + change + "'  WHERE EmployeeId = " + employeeID + "       ;";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
