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
    public class DishController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IDishRepository repository = new DishRepository();
        private IMapper _mapper;

        public DishController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpGet("{search?}")]
        public async Task<ActionResult<IEnumerable<DishDTO>>> GetAsync(string? search)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<Dish> c = repository.GetDishs((int)user.EducationId, search);
            IEnumerable<DishDTO> cDTO = _mapper.Map<IEnumerable<DishDTO>>(c);
            return Ok(cDTO);
        }
        [HttpGet("find/{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Dish c = repository.FindDishById(id);
            if (c == null) return NotFound();
            DishDTO cDTO = _mapper.Map<DishDTO>(c);
            return Ok(cDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] DishDTO DishDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);
                var user = await _userManager.FindByNameAsync(usernameClaim.Value);
                Dish d= _mapper.Map<Dish>(DishDTO);
                d.EducationId = user.EducationId;
                repository.CreateDish(d);
                DishDTO.DishId = d.DishId;
                return Created(Request.GetDisplayUrl(), DishDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DishDTO DishDTO)
        {
            var s = repository.FindDishById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.DishName = DishDTO.DishName;
            s.Nutrition = DishDTO.Nutrition;
            s.Description = DishDTO.Description;
            s.MealTypeId = DishDTO.MealTypeId;
            repository.UpdateDish(s);
            return NoContent();
        }
    }
}
