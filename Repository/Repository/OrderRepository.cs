using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void CreateOrder(Order a) => OrderDAO.CreateOrder(a);

        public Order FindOrderById(int id) => OrderDAO.FindOrderById(id);

        public List<Order> GetOrders(int educationId) => OrderDAO.GetOrders(educationId);

        public void UpdateOrder(Order a) => OrderDAO.UpdateOrder(a);
    }
}
