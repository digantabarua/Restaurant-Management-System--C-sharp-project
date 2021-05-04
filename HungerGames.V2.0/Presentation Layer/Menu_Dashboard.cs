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
    public partial class Menu_Dashboard : Form
    {
        MenuDataAccess mda;
        MenuService ms;
        int id;
        public Menu_Dashboard()
        {
            InitializeComponent();
            mda = new MenuDataAccess();
            ms = new MenuService();
            dataGridView1.DataSource = mda.GetMenuData();
        }

        private void Menu_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MenuNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            QuantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TypeComboBox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MenuNameTextBox.Text))
            {
                if (!string.IsNullOrEmpty(TypeComboBox.SelectedIndex.ToString()))
                {
                    if (!string.IsNullOrEmpty(priceTextBox.Text))
                    {
                        int result = ms.AddMenu(MenuNameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(QuantityTextBox.Text), TypeComboBox.SelectedItem.ToString());
                        if (result == 1)
                        {
                            MessageBox.Show("Item successfully added to menu!");
                            mda = new MenuDataAccess();
                            dataGridView1.DataSource = mda.GetMenuData();
                            MenuNameTextBox.Clear();
                            priceTextBox.Clear();
                            QuantityTextBox.Clear();
                            TypeComboBox.SelectedItem = null;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a price!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter quantity!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter name!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int result = ms.EditMenu(id, MenuNameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(QuantityTextBox.Text), TypeComboBox.SelectedItem.ToString());
            mda = new MenuDataAccess();
            dataGridView1.DataSource = mda.GetMenuData();
            MessageBox.Show("Item details successfully saved!");
            MenuNameTextBox.Clear();
            priceTextBox.Clear();
            QuantityTextBox.Clear();
            TypeComboBox.SelectedItem = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int result = ms.DeleteMenu(Convert.ToInt32(deleteTextBox.Text));
            if (result == 1)
            {
                MessageBox.Show("Item is deleted from Menu successfully!");
                mda = new MenuDataAccess();
                dataGridView1.DataSource = mda.GetMenuData();
                deleteTextBox.Clear();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard m = new Admin_Dashboard();
            m.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MenuNameTextBox.Clear();
            priceTextBox.Clear();
            QuantityTextBox.Clear();
            TypeComboBox.SelectedItem = null;
        }
    }
}
