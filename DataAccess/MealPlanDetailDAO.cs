using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MealPlanDetailDAO
    {
        public static List<MealPlanDetail> GetMealPlanDetails(int MealPlanID)
        {
            var MealPlanDetails = new List<MealPlanDetail>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    MealPlanDetails = context.MealPlanDetails.Where(x => x.MealPlanID == MealPlanID).ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return MealPlanDetails;
        }
        public static MealPlanDetail FindMealPlanDetailById(int MealPlanID, int DishId)
        {
            MealPlanDetail p = new MealPlanDetail();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.MealPlanDetails.SingleOrDefault(x => x.MealPlanID == MealPlanID && x.DishId == DishId);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateMealPlanDetail(MealPlanDetail a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.MealPlanDetails.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateMealPlanDetail(MealPlanDetail a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<MealPlanDetail>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteMealPlanDetail(int MealPlanID)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    var MealPlanDetails = context.MealPlanDetails.Where(x => x.MealPlanID == MealPlanID).ToList();
                    context.RemoveRange(MealPlanDetails);
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
