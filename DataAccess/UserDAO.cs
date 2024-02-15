using Data.Context;
using Data.DTO;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        public static List<User> GetUsers()
        {
            var listUsers = new List<User>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    listUsers = context.Users.ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return listUsers;
        }
        public static User FindUserById(Guid userId)
        {
            User c = new User();
            try
            {
                using (var context = new MMCDbContext())
                {
                    c = context.Users.SingleOrDefault(x => x.Id == userId);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return c;
        }
        public static void UpdateUser(User c)
        {
            
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<User>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
