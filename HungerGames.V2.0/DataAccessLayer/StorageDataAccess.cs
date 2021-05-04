using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class StorageDataAccess
    {
        DataAccess sda;
        public StorageDataAccess()
        {
            sda = new DataAccess();
        }

        public List<Storage> GetStorageData()
        {
            sda = new DataAccess();
            string sql = "SELECT * FROM Storages;";
            SqlDataReader reader = sda.GetData(sql);
            List<Storage> list = new List<Storage>();
            while (reader.Read())
            {
                Storage s = new Storage();
                s.ProductId = (int)reader["ProductId"];
                s.ProductName = reader["ProductName"].ToString();
                s.Quantity = (int)reader["Quantity"];
                s.StorageMonth = reader["StorageMonth"].ToString();
                s.Price = (int)reader["Price"];
                list.Add(s);
            }
            return list;
        }

        public int AddProduct(Storage s)
        {
            sda = new DataAccess();
            string sql = "INSERT INTO Storages(ProductName,Quantity,StorageMonth,Price) VALUES('" + s.ProductName + "','" + s.Quantity + "','" + s.StorageMonth + "','" + s.Price + "')";
            return sda.ExecuteQuery(sql);
        }

        public int DeleteProduct(int pid)
        {
            sda = new DataAccess();
            string sql = "DELETE FROM Storages WHERE ProductId='" + pid + "';";
            return sda.ExecuteQuery(sql);
        }

        public int EditProduct(int pid, string pn, int q, string sm, float p)
        {
            sda = new DataAccess();
            string sql = "UPDATE Storages SET ProductName='" + pn + "' , Quantity='" + q + "',StorageMonth='" + sm + "',Price='" + p + "' WHERE ProductId='" + pid + "'";
            return sda.ExecuteQuery(sql);
        }

        //public int SubInventory(int id, int quantity)
        //{
        //    sda = new DataAccess();
        //    string sql = "UPDATE Storages SET  Quantity='" + quantity + "' WHERE ProductId='" + id + "'";
        //    return sda.ExecuteQuery(sql);
        //}

        public int AddStorage(int id, int quantity, int p)
        {
            sda = new DataAccess();
            string sql = "UPDATE Storages SET  Quantity='" + quantity + "', Price='" + p + "' WHERE ProductId='" + id + "'";
            return sda.ExecuteQuery(sql);
        }

        public List<string> GetProductName()
        {
            sda = new DataAccess();
            string sql = "SELECT ProductName FROM Storages;";
            SqlDataReader reader = sda.GetData(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string str = reader["ProductName"].ToString();
                list.Add(str);
            }
            return list;
        }
    }
}
