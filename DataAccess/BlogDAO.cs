using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlogDAO
    {
        public static List<Blog> GetBlogs()
        {
            var listBlogs = new List<Blog>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    listBlogs = context.Blogs.ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return listBlogs;
        }
        public static Blog FindBlogById(int id)
        {
            Blog p = new Blog();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Blogs.SingleOrDefault(x => x.ID == id);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreateBlog(Blog a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Blogs.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateBlog(Blog a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Blog>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteBlog(Blog a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    var blog = context.Blogs.SingleOrDefault(x => x.ID == a.ID);
                    context.Blogs.Remove(blog);
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
