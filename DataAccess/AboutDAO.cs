using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AboutDAO
    {
        public static About FindAbout()
        {
            About c = new About();
            try
            {
                using (var context = new MMCDbContext())
                {
                    c = context.Abouts.ToList().FirstOrDefault();

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return c;
        }
        public static void UpdateAbout(About a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<About>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void CreateAbout(About a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Abouts.Add(a);
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
