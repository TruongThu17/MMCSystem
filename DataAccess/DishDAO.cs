using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DishDAO
    {
        public static List<Dish> GetDishs(int educationId, string? search)
        {
            var Dishs = new List<Dish>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    Dishs = context.Dishs.Where(x => x.EducationId == educationId).ToList();
                    foreach (var item in Dishs)
                    {
                        item.MealType = context.MealTypes.SingleOrDefault(x => x.Id == item.MealTypeId);
                    }
                    if (search!=null)
                        Dishs = Dishs.Where(x=>x.DishName.ToLower().Contains(search.ToLower()) 
                        || x.Description.ToLower().Contains(search.ToLower())
                        || x.Nutrition.ToLower().Contains(search.ToLower())
                        || x.MealType.Name.ToLower().Contains(search.ToLower())
                        ).ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return Dishs;
        }
        public static Dish FindDishById(int id)
        {
            Dish p = new Dish();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Dishs.SingleOrDefault(x => x.DishId == id);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateDish(Dish a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Dishs.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateDish(Dish a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Dish>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
