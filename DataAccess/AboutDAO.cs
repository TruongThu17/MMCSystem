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
    }
}
