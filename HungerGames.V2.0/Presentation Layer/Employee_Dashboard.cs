using HungerGames.V2._0.Business_Logic_Layer;
using HungerGames.V2._0.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungerGames.V2._0.Presentation_Layer
{
    public partial class Employee_Dashboard : Form
    {
        DataAccess da;
        OrderService os;
        int Orderid, Employeeid, Totalamount;
        string EmployeeName, Month;
        public Employee_Dashboard()
        {
            InitializeComponent();
            da = new DataAccess();
            os = new OrderService();
        }

        private void Employee_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ShowUserbutton_Click(object sender, EventArgs e)
        {
            Waiter_Information i = new Waiter_Information();
            i.Show();
        }

        private void storagebutton_Click(object sender, EventArgs e)
        {
            WaiterStorage s = new WaiterStorage();
            s.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            WaiterMenu w = new WaiterMenu();
            w.Show();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_Dashboard od = new Order_Dashboard();
            od.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
