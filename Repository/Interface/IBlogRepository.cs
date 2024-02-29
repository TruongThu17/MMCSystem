using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogs();
        Blog FindBlogById(int id);
        void CreateBlog(Blog a);
        void UpdateBlog(Blog a);
        void DeleteBlog(Blog a);
    }
}
