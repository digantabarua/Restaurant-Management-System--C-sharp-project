using HungerGames.V2._0.Business_Logic_Layer;
using HungerGames.V2._0.DataAccessLayer;
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
    public partial class EmployeeEdit_Dashboard : Form
    {
        private SqlConnection connection;
        EmployeeDataAccess eda;
        EmployeeService es;
        int id;
        string status;
        private SqlCommand cmd;
        public EmployeeEdit_Dashboard()
        {
            InitializeComponent();
            eda = new EmployeeDataAccess();
            es = new EmployeeService();
            dataGridView1.DataSource = eda.GetEmployeeData();
        }

        private void EmployeeEdit_DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();


            string employeeID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ColumnName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            string change = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string query = "UPDATE Employees set " + ColumnName + " = '" + change + "'  WHERE " + "EmployeeId = " + employeeID + "       ;";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard h = new Admin_Dashboard();
            h.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            es = new EmployeeService();
            int result = es.DeleteEmployee(Convert.ToInt32(deleteTextBox.Text));
            if (result == 1)
            {
                MessageBox.Show("Employee information deleted from Employee table successfully!");
                eda = new EmployeeDataAccess();
                dataGridView1.DataSource = eda.GetEmployeeData();
                deleteTextBox.Clear();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            if (nameTextBox.Text == "") { MessageBox.Show("Select name"); }
            else if (passwordTextBox.Text == "") { MessageBox.Show("Select a password"); }
            else if (confirmpasswordtextBox.Text == "") { MessageBox.Show("Type password"); }
            else if (confirmpasswordtextBox.Text == "") { MessageBox.Show("Type password"); }
            else if (phoneTextBox.Text == "") { MessageBox.Show("Enter Phone Number"); }
            else if (NidtextBox.Text == "") { MessageBox.Show("Enter NID Number"); }
            else if (gendercomboBox.Text == "") { MessageBox.Show("Enter Gender"); }
            else if (bgComboBox.Text == "") { MessageBox.Show("Enter Blood Group"); }
            else if (addressTextBox.Text == "") { MessageBox.Show("Enter Address"); }
            else if (dateTimePicker1.Text == "") { MessageBox.Show("Enter Date of Birth"); }
            else if (stautscomboBox1.Text == "") { MessageBox.Show("Enter a Role"); }
            else
            {
                if (passwordTextBox.Text == confirmpasswordtextBox.Text)
                {
                    string query = "INSERT INTO Employees(EmployeeName,EmployeePassword,EmployeePhone,EmployeeNid,EmployeeGender,EmployeeBloodGroup,EmployeeAddress,EmployeeDoB,EmployeeStatus) VALUES('" + nameTextBox.Text + "','" + passwordTextBox.Text + "','" + phoneTextBox.Text + "','" + NidtextBox.Text + "','" + gendercomboBox.Text + "','" + bgComboBox.Text + "','" + addressTextBox.Text + "','" + dateTimePicker1.Text + "','" + stautscomboBox1.Text + "');";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = eda.GetEmployeeData();
                    deleteTextBox.Clear();
                    MessageBox.Show(" Account has been created");
                    nameTextBox.Clear();
                    passwordTextBox.Clear();
                    phoneTextBox.Clear();
                    NidtextBox.Clear();
                    gendercomboBox.Text = null;
                    bgComboBox.Text = null;
                    addressTextBox.Clear();
                    dateTimePicker1.Text = null;
                    confirmpasswordtextBox.Clear();
                    stautscomboBox1.Text = null;
                }
            }

            connection.Close();
        }

        private void EmployeeEdit_DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
