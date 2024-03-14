using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Security.Claims;

namespace MMCSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IClassRepository repository = new ClassRepository();
        private IMapper _mapper;

        public ClassController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassDTO>>> GetAsync()
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);

            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<Class> c = repository.GetClasses((int)user.EducationId);
            IEnumerable<ClassDTO> cDTO = _mapper.Map<IEnumerable<ClassDTO>>(c);
            return Ok(cDTO);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Class c = repository.FindClassById(id);
            if (c == null) return NotFound();
            ClassDTO cDTO = _mapper.Map<ClassDTO>(c);
            return Ok(cDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ClassDTO classDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);
                var user = await _userManager.FindByNameAsync(usernameClaim.Value);
                Class c = new Class()
                {
                    ClassName = classDTO.ClassName,
                    ClassTypeId =(int)classDTO.ClassTypeId,
                    EducationId = (int)user.EducationId
                };
                repository.CreateClass(c);
                classDTO.ClassId = c.ClassId;
                return Created(Request.GetDisplayUrl(), classDTO);
            }
            return BadRequest(ModelState);
        }
        //// PUT api/<MedicalFacility>/5
        //[HttpPut("{id}")]
        //[Authorize(Roles = "SuperAdmin")]
        //public ActionResult Put(int id, [FromBody] Blog blog)
        //{
        //    var s = repository.FindBlogById(id);
        //    if (s == null) return NotFound();
        //    if (!ModelState.IsValid) return BadRequest(ModelState);
        //    repository.UpdateBlog(blog);
        //    return NoContent();
        //}
    }
}
