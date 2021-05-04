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
    public partial class Admin_Dashboard : Form
    {
        DataAccess da;
        OrderService os;
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeEdit_Dashboard ed = new EmployeeEdit_Dashboard();
            ed.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Dashboard md = new Menu_Dashboard();
            md.Show();
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            this.Hide();
            Storage_Dashboard sd = new Storage_Dashboard();
            sd.Show();
        }

        private void OrderHistorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistory od = new OrderHistory();
            od.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
