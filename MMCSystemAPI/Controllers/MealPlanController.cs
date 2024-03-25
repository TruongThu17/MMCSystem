using AutoMapper;
using Data.DTO;
using Data.Models;
using DataAccess;
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
    public class MealPlanController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IMealPLanRepository repository = new MealPLanRepository();
        private IMapper _mapper;

        public MealPlanController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealPLanDTO>>> GetAsync()
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);

            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<MealPlan> ct = repository.GetMealPlans((int)user.EducationId);
            IEnumerable<MealPLanDTO> ctDTO = _mapper.Map<IEnumerable<MealPLanDTO>>(ct);
            return Ok(ctDTO);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            MealPlan MealPlan = repository.FindMealPlanById(id);
            if (MealPlan == null) return NotFound();
            MealPLanDTO MealPlanDTO = _mapper.Map<MealPLanDTO>(MealPlan);
            return Ok(MealPlanDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] MealPLanDTO mealPLanDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);
                var user = await _userManager.FindByNameAsync(usernameClaim.Value);
                MealPlan MealPlan = _mapper.Map<MealPlan>(mealPLanDTO);
                MealPlan.EducationId = user.EducationId;
                repository.CreateMealPlan(MealPlan);
                mealPLanDTO.MealPlanID = MealPlan.MealPlanID;
                return Created(Request.GetDisplayUrl(), mealPLanDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] MealPLanDTO MealPLanDTO)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            var s = repository.FindMealPlanById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.DatePlan = MealPLanDTO.DatePlan;
            s.MealPlanName = MealPLanDTO.MealPlanName;
            s.MealTypeId = MealPLanDTO.ClassTypeId;
            s.ClassTypeId = MealPLanDTO.ClassTypeId;
            s.Description = MealPLanDTO.Description;
            repository.UpdateMealPlan(s);
            return NoContent();
        }
    }
}
