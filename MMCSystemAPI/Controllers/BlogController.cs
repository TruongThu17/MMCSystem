using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
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
        [HttpGet("Top4")]
        public ActionResult<IEnumerable<Blog>> GetTop4()
        {
            IEnumerable<Blog> blogs = repository.GetBlogs();

            // Order blogs by timestamp in descending order and take the top 4
            var top4RecentBlogs = blogs.OrderByDescending(b => b.Date).Take(4);

            return Ok(top4RecentBlogs);
        }

        [HttpGet("search/{search}")]
        public ActionResult<IEnumerable<Blog>> Search(string search)
        {
            IEnumerable<Blog> bl = repository.GetBlogs().Where(b =>
                                        b.Tilte.ToLower().Contains(search.ToLower()) ||
                                        b.Description.ToLower().Contains(search.ToLower())
                                    ).ToList();
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
        [HttpGet("blogDTO/{id}")]
        public ActionResult GetBlogDTO(int id)
        {
            if (id == null) return BadRequest();
            Blog blog = repository.FindBlogById(id);
            if (blog == null) return NotFound();
            BlogDTO bDTO = _mapper.Map<BlogDTO>(blog);
            return Ok(bDTO);
        }
        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Post([FromBody] Blog blog)
        {
            if (ModelState.IsValid)
            {
                repository.CreateBlog(blog);
                return Created(Request.GetDisplayUrl(), blog);
            }
            return BadRequest(ModelState);
        }
        // PUT api/<MedicalFacility>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Put(int id, [FromBody] Blog blog)
        {
            var s = repository.FindBlogById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            repository.UpdateBlog(blog);
            return NoContent();
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Delete(int id)
        {
            var s = repository.FindBlogById(id);
            if (s == null) return NotFound();
            else
            {
                repository.DeleteBlog(s);
                return NoContent();
            }
        }
    }
}
