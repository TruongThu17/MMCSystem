using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class BlogRepository : IBlogRepository
    {
        public void CreateBlog(Blog a) => BlogDAO.CreateBlog(a);

        public void DeleteBlog(Blog a) => BlogDAO.DeleteBlog(a);

        public Blog FindBlogById(int id) => BlogDAO.FindBlogById(id);

        public List<Blog> GetBlogs() => BlogDAO.GetBlogs();

        public void UpdateBlog(Blog a)=> BlogDAO.UpdateBlog(a);
    }
}
