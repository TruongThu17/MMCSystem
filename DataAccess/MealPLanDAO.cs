using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MealPLanDAO
    {
        public static List<MealPlan> GetMealPlans(int educationId)
        {
            var MealPlans = new List<MealPlan>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    MealPlans = context.MealPlans.Where(x => x.EducationId == educationId).ToList();
                    foreach (var item in MealPlans)
                    {
                        item.MealType = context.MealTypes.SingleOrDefault(x => x.Id == item.MealTypeId);
                        item.ClassType = context.ClassTypes.SingleOrDefault(x => x.ClassTypeId == item.ClassTypeId);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return MealPlans;
        }
        public static MealPlan FindMealPlanById(int id)
        {
            MealPlan p = new MealPlan();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.MealPlans.SingleOrDefault(x => x.MealPlanID == id);
                    p.MealPlanDetails = context.MealPlanDetails.Where(x => x.MealPlanID == id).ToList();
                    p.MealType = context.MealTypes.SingleOrDefault(x => x.Id == p.MealTypeId);
                    p.ClassType = context.ClassTypes.SingleOrDefault(x => x.ClassTypeId == p.ClassTypeId);
                    p.ClassType = context.ClassTypes.SingleOrDefault(x => x.ClassTypeId == p.ClassTypeId);
                    foreach (var item in p.MealPlanDetails)
                    {
                        item.Dish = context.Dishs.SingleOrDefault(x => x.DishId == item.DishId);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateMealPlan(MealPlan a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.MealPlans.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateMealPlan(MealPlan a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<MealPlan>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
