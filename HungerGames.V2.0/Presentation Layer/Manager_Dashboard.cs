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
    public partial class Manager_Dashboard : Form
    {
        DataAccess da;
        OrderService os;
        public Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void Manager_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Menu md = new Manager_Menu();
            md.Show();
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            this.Hide();
            Manager_Storage sd = new Manager_Storage();
            sd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Information manager_Information = new Manager_Information();
            manager_Information.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
