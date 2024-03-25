using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders(int educationId)
        {
            var Orders = new List<Order>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    Orders = context.Orders.Where(x=>x.EducationId== educationId).ToList();
                    foreach (var item in Orders)
                    {
                        item.Class = context.Classes.SingleOrDefault(x => x.ClassId == item.ClassId);
                        item.MealPlan = context.MealPlans.SingleOrDefault(x => x.MealPlanID == item.MealPlanId);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Orders;
        }

        public static Order FindOrderById(int id)
        {
            Order p = new Order();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Orders.SingleOrDefault(x => x.OrderId == id);
                    p.Class = context.Classes.SingleOrDefault(x => x.ClassId == p.ClassId);
                    p.MealPlan = context.MealPlans.SingleOrDefault(x => x.MealPlanID == p.MealPlanId);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateOrder(Order a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Orders.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateOrder(Order a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Order>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
