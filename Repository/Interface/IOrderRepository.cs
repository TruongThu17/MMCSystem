using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetOrders(int educationId);
        Order FindOrderById(int id);
        void CreateOrder(Order a);
        void UpdateOrder(Order a);
    }
}
