using HungerGames.V2._0.Business_Logic_Layer;
using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
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
    public partial class Login : Form
    {
        DataAccess da;
        OrderService os;
        private object Waiter_dashbord;
        public Login()
        {
            InitializeComponent();
            da = new DataAccess();
            os = new OrderService();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Enter Your User Name!");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter Your Password!");
            }

            else
            {
                string query = "select * from Employees where EmployeeName = '" + this.UserNameTextBox.Text + "' and EmployeePassword = '" + this.PasswordTextBox.Text + "';";
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
                connection.Open();
                SqlCommand sqlcom = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    da = new DataAccess();
                    string sql = "SELECT EmployeeStatus FROM Employees WHERE EmployeeName='" + UserNameTextBox.Text + "'";
                    SqlDataReader reader1 = da.GetData(sql);
                    Employee em = new Employee();
                    while (reader1.Read())
                        em.EmployeeStatus = reader1["EmployeeStatus"].ToString();
                    if (em.EmployeeStatus == "Admin")
                    {
                        Admin_Dashboard admin_Dashbord = new Admin_Dashboard();
                        admin_Dashbord.Show();
                        this.Hide();
                    }
                    else if (em.EmployeeStatus == "Manager")
                    {
                        Manager_Dashboard manager_Dashbord = new Manager_Dashboard();
                        manager_Dashbord.Show();
                        this.Hide();
                    }
                    else if (em.EmployeeStatus == "Waiter")
                    {
                        Employee_Dashboard employee_Dashbord = new Employee_Dashboard();
                        employee_Dashbord.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Input is Invalid");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong ID or, Invalid Password!");
                }


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
