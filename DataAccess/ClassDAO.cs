using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClassDAO
    {
        public static List<Class> GetClasses(int educationId)
        {
            var classDetails = new List<Class>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    classDetails = (from c in context.Classes
                                    join e in context.Educations on c.EducationId equals e.Id
                                    join ct in context.ClassTypes on c.ClassTypeId equals ct.ClassTypeId
                                    where c.EducationId == educationId
                                    select new Class
                                    {
                                        ClassId = c.ClassId,
                                        ClassName = c.ClassName,
                                        Education = e,
                                        ClassType = ct
                                        
                                    }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return classDetails;
        }

        public static Class FindClassById(int id)
        {
            Class p = new Class();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Classes.SingleOrDefault(x => x.ClassId == id);
                    p.Education = context.Educations.SingleOrDefault(x=>x.Id == p.EducationId);
                    p.ClassType = context.ClassTypes.SingleOrDefault(x=>x.ClassTypeId == p.ClassTypeId);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateClass(Class a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Classes.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateClass(Class a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Class>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
