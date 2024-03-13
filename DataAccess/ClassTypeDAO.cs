using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClassTypeDAO
    {
        public static List<ClassType> GetClassTypes()
        {
            var ClassTypes = new List<ClassType>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    ClassTypes = context.ClassTypes.ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return ClassTypes;
        }
        public static ClassType FindClassTypeById(int id)
        {
            ClassType p = new ClassType();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.ClassTypes.SingleOrDefault(x => x.ClassTypeId == id);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateClassType(ClassType a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.ClassTypes.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateClassType(ClassType a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<ClassType>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
