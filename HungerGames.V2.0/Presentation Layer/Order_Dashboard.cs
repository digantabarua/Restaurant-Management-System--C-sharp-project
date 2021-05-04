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
    public partial class Order_Dashboard : Form
    {
        MenuService ms;
        DataAccess da;
        OrderService os;
        int x;
        public Order_Dashboard()
        {
            InitializeComponent();
            ms = new MenuService();
            da = new DataAccess();
            os = new OrderService();
            itemComboBox.DataSource = ms.GetMenuName();
        }

        private void Order_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int a;
        string text, text2;

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (orderListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item from Menu!");
            }
            else
            {
                orderListBox.Items.RemoveAt(orderListBox.SelectedIndex);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Varriables.a = 0;
            orderListBox.Items.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
            employee_Dashboard.Show();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            int a = 0;
            string text = "_ _ _ _ _ _ _ _ _ _ _ _ _ ";
            string text2 = "    Total      =       " + Varriables.total(a) + "TAKA";
            orderListBox.Items.Add(text);
            orderListBox.Items.Add(text2);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Orders (EmployeeName, EmployeeId, Month, Price) VALUES ('" + nametextBox.Text + "','" + idtextBox.Text + "','" + dateTimePicker1.Text + "','" + Varriables.total(a) + "');";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();



            MessageBox.Show("Your order has been placed");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(QuatityTextBox.Text))
                {
                    da = new DataAccess();
                    string sql = "SELECT Price FROM Menu WHERE MenuName='" + itemComboBox.SelectedItem.ToString() + "' ";
                    SqlDataReader reader = da.GetData(sql);
                    Menus m = new Menus();
                    while (reader.Read())
                    {
                        m.Price = (int)reader["Price"];
                    }
                    x = Convert.ToInt32(m.Price) * Convert.ToInt32(QuatityTextBox.Text);
                    string text = itemComboBox.SelectedItem.ToString() + "    " + QuatityTextBox.Text + "    " + x + "taka";
                    orderListBox.Items.Add(text);
                    itemComboBox.SelectedItem = null;
                    QuatityTextBox.Clear();
                    Varriables.total(x);

                }
                else
                {
                    MessageBox.Show("Please Select Quantity!");
                }
            }
            else
            {
                MessageBox.Show("Please select an item!");
            }
        }
    }
}
