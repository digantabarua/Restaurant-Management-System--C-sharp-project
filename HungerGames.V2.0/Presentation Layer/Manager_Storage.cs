using HungerGames.V2._0.Business_Logic_Layer;
using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungerGames.V2._0.Presentation_Layer
{
    public partial class Manager_Storage : Form
    {
        StorageService s;
        DataAccess da;
        int id;
        string month;
        public Manager_Storage()
        {
            InitializeComponent();
            s = new StorageService();
            da = new DataAccess();
            StorageComboBox.DataSource = s.GetProductName();
            dataGridView1.DataSource = s.GetStorageData();
        }

        private void Manager_Storage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            pNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pQuantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            string sql = "SELECT Quantity,ProductId,Price FROM Storages WHERE ProductName='" + StorageComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = da.GetData(sql);
            Storage i = new Storage();
            while (reader.Read())
            {
                i.ProductId = (int)reader["ProductId"];
                i.Quantity = (int)reader["Quantity"];
                i.Price = (int)reader["Price"];
            }
            int cal = i.Quantity + Convert.ToInt32(amountTextBox.Text);
            int p = ((i.Price / i.Quantity) * Convert.ToInt32(amountTextBox.Text)) + i.Price;
            s = new StorageService();
            int result = s.AddStorage(i.ProductId, cal, p);
            dataGridView1.DataSource = s.GetStorageData();
            MessageBox.Show("Amount added!");
            StorageComboBox.SelectedItem = null;
            amountTextBox.Clear();
        }

        private void newstorageButton_Click(object sender, EventArgs e)
        {

            da = new DataAccess();
            string sql = "SELECT ProductName FROM Storages";
            SqlDataReader reader = da.GetData(sql);
            Storage i = new Storage();
            while (reader.Read())
            {
                i.ProductName = reader["ProductName"].ToString();
            }
            if (pNameTextBox.Text != i.ProductName && !string.IsNullOrEmpty(pNameTextBox.Text))
            {
                if (!string.IsNullOrEmpty(priceTextBox.Text))
                {
                    int result = s.AddProduct(pNameTextBox.Text, Convert.ToInt32(amountTextBox.Text), dateTimePicker1.Text, Convert.ToInt32(priceTextBox.Text));
                    if (result == 1)
                    {
                        MessageBox.Show("Inventory Successfully Added!");
                        s = new StorageService();
                        dataGridView1.DataSource = s.GetStorageData();
                        StorageComboBox.DataSource = s.GetProductName();
                        //pNameTextBox.Clear();
                        //pQuantityTextBox.Clear();
                        //priceTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the price field!");
                }
            }
            else
            {
                MessageBox.Show("Same Storage name.\nOr,\nYou didn't fill the Inventory name field!");
            }
        }

        private void EditStorageButton_Click(object sender, EventArgs e)
        {

            int result = s.EditProduct(id, pNameTextBox.Text, Convert.ToInt32(pQuantityTextBox.Text), month, Convert.ToInt32(dateTimePicker1.Text));
            s = new StorageService();
            dataGridView1.DataSource = s.GetStorageData();
            StorageComboBox.DataSource = s.GetProductName();
            MessageBox.Show("Inventory details successfully saved!");
            pNameTextBox.Clear();
            pQuantityTextBox.Clear();
            priceTextBox.Clear();
        }

        private void deleteInventoryButton_Click(object sender, EventArgs e)
        {
            int result = s.DeleteProduct(Convert.ToInt32(dproductTextBox.Text));
            if (result == 1)
            {
                MessageBox.Show("Product successfully deleted!");
                s = new StorageService();
                dataGridView1.DataSource = s.GetStorageData();
                StorageComboBox.DataSource = s.GetProductName();
                dproductTextBox.Clear();
            }
        }

        private void ShowStorageButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            //GetStorages();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Dashboard m = new Manager_Dashboard();
            m.Show();
        }
    }
}
