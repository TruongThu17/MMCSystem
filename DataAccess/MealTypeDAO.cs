using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MealTypeDAO
    {
        public static List<MealType> GetMealTypes(int educationId)
        {
            var MealTypes = new List<MealType>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    MealTypes = context.MealTypes.Where(x=>x.EducationId==educationId).ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return MealTypes;
        }
        public static MealType FindMealTypeById(int id)
        {
            MealType p = new MealType();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.MealTypes.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateMealType(MealType a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.MealTypes.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateMealType(MealType a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<MealType>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
