using AutoMapper;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace MMCSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogRepository repository = new BlogRepository();
        private IMapper _mapper;

        public BlogController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            IEnumerable<Blog> bl = repository.GetBlogs();
            return Ok(bl);
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Blog blog = repository.FindBlogById(id);
            if (blog == null) return NotFound();
            return Ok(blog);
        }
    }
}
