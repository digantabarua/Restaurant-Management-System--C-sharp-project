using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.Business_Logic_Layer
{
    class OrderService
    {
        OrderDataAccess oda;
        public OrderService()
        {
            oda = new OrderDataAccess();
        }

        public int AddOrder(string month, int s, string ename, int eid)
        {
            Order o = new Order() { Month = month, Price = s, EmployeeName = ename, EmployeeId = eid };
            return oda.AddOrder(o);
        }

        public int DeleteOrder(int dorder)
        {
            return oda.DeleteOrder(dorder);
        }

        public List<Order> GetOrderData()
        {
            return oda.GetOrderData();
        }
    }
}
