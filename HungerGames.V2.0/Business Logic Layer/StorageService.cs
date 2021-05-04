using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.Business_Logic_Layer
{
    class StorageService
    {
        StorageDataAccess sda;
        public StorageService()
        {
            sda = new StorageDataAccess();
        }

        public int AddProduct(string pname, int amount, string month, int p)
        {
            Storage s = new Storage() { ProductName = pname, Quantity = amount, StorageMonth = month, Price = p };
            return sda.AddProduct(s);
        }

        public int DeleteProduct(int id)
        {
            return sda.DeleteProduct(id);
        }

        public int EditProduct(int id, string iname, int amount, string month, int p)
        {
            return sda.EditProduct(id, iname, amount, month, p);
        }

        //public int SubInventory(int id, int amount)
        //{
        //    return sda.SubInventory(id, amount);
        //}

        public int AddStorage(int id, int amount, int p)
        {
            return sda.AddStorage(id, amount, p);
        }

        public List<Storage> GetStorageData()
        {
            return sda.GetStorageData();
        }

        public List<string> GetProductName()
        {
            return sda.GetProductName();
        }
    }
}
