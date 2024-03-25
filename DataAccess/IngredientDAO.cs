using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class IngredientDAO
    {
        public static List<Ingredient> GetIngredients(int educationId)
        {
            var listIngredients = new List<Ingredient>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    listIngredients = context.Ingredients.Where(x => x.EducationId == educationId).ToList();
                    foreach (var item in listIngredients)
                    {
                        item.Supplier = context.Suppliers.SingleOrDefault(x => x.SupplierId == item.SupplierId);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return listIngredients;
        }
        public static List<Ingredient> ReportMonths(int educationId)
        {
            var listIngredients = new List<Ingredient>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    listIngredients = context.Ingredients.Where(x => x.EducationId == educationId).ToList();
                    foreach (var item in listIngredients)
                    {
                        item.Supplier = context.Suppliers.SingleOrDefault(x => x.SupplierId == item.SupplierId);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return listIngredients;
        }
        public static Ingredient FindIngredientById(int id)
        {
            Ingredient p = new Ingredient();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Ingredients.SingleOrDefault(x => x.IngredientId == id);
                    p.Supplier = context.Suppliers.SingleOrDefault(x => x.SupplierId == p.SupplierId);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreatIngredient(Ingredient a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Ingredients.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateIngredient(Ingredient a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Ingredient>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
