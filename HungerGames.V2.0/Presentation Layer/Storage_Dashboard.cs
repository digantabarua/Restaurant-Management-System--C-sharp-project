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
    public partial class Storage_Dashboard : Form
    {
        StorageService s;
        DataAccess da;
        int id;
        string month;
        private SqlCommand cmd;
        public Storage_Dashboard()
        {
            InitializeComponent();
            s = new StorageService();
            da = new DataAccess();
            StorageComboBox.DataSource = s.GetProductName();
            dataGridView1.DataSource = s.GetStorageData();
        }

        private void Storage_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            connection.Open();
            string query = "INSERT INTO Storages(ProductName,Quantity,StorageMonth,Price) VALUES('" + pNameTextBox.Text + "','" + pQuantityTextBox.Text + "','" + dateTimePicker1.Text + "','" + priceTextBox.Text + "');";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MessageBox.Show(" Storage has been updated");
            pNameTextBox.Clear();
            pQuantityTextBox.Clear();
            dateTimePicker1.Text = null;
            priceTextBox.Clear();
        }

        private void ShowStorageButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            //GetStorageData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashbord = new Admin_Dashboard();
            admin_Dashbord.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            pNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pQuantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
