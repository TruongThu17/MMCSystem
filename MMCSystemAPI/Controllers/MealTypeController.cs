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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MealTypeController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IMealTypeRepository repository = new MealTypeRepository();
        private IMapper _mapper;

        public MealTypeController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealTypeDTO>>> GetAsync()
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);

            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<MealType> ct = repository.GetMealTypes((int) user.EducationId);
            IEnumerable<MealTypeDTO> ctDTO = _mapper.Map<IEnumerable<MealTypeDTO>>(ct);
            return Ok(ctDTO);
        }

        //[HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    if (id == null) return BadRequest();
        //    ClassType ClassType = repository.FindClassTypeById(id);
        //    if (ClassType == null) return NotFound();
        //    ClassTypeDTO ClassTypeDTO = _mapper.Map<ClassTypeDTO>(ClassType);
        //    return Ok(ClassTypeDTO);
        //}
        //[HttpPost]
        //public ActionResult Post([FromBody] ClassTypeDTO ClassTypeDTO)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ClassType ClassType = _mapper.Map<ClassType>(ClassTypeDTO);
        //        repository.CreateClassType(ClassType);
        //        ClassTypeDTO.ClassTypeId = ClassType.ClassTypeId;
        //        return Created(Request.GetDisplayUrl(), ClassTypeDTO);
        //    }
        //    return BadRequest(ModelState);
        //}
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] ClassTypeDTO ClassTypeDTO)
        //{
        //    var s = repository.FindClassTypeById(id);
        //    if (s == null) return NotFound();
        //    if (!ModelState.IsValid) return BadRequest(ModelState);
        //    ClassTypeDTO.ClassTypeId = s.ClassTypeId;
        //    repository.UpdateClassType(s);
        //    return NoContent();
        //}
    }
}
