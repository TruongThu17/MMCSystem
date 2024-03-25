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

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            MealType MealType = repository.FindMealTypeById(id);
            if (MealType == null) return NotFound();
            MealTypeDTO MealTypeDTO = _mapper.Map<MealTypeDTO>(MealType);
            return Ok(MealTypeDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] MealTypeDTO MealTypeDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);

                var user = await _userManager.FindByNameAsync(usernameClaim.Value);
                MealType MealType = _mapper.Map<MealType>(MealTypeDTO);
                MealType.EducationId = (int)user.EducationId;
                repository.CreateMealType(MealType);
                MealTypeDTO.Id = MealTypeDTO.Id;
                return Created(Request.GetDisplayUrl(), MealTypeDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MealTypeDTO MealTypeDTO)
        {
            var s = repository.FindMealTypeById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.Name = MealTypeDTO.Name;
            repository.UpdateMealType(s);
            return NoContent();
        }
    }
}
