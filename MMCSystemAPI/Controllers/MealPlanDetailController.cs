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
    public class MealPlanDetailController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IMealPlanDetailRepository repository = new MealPlanDetailRepository();
        private IMapper _mapper;

        public MealPlanDetailController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        [HttpGet("{MealPlanID}/{DishId}")]
        public ActionResult Get(int MealPlanID, int DishId)
        {
            if (MealPlanID == null || DishId ==null) return BadRequest();
            MealPlanDetail MealPlanDetail = repository.FindMealPlanDetailById(MealPlanID, DishId);
            if (MealPlanDetail == null) return NotFound();
            MealPlanDetailDTO MealPlanDetailDTO = _mapper.Map<MealPlanDetailDTO>(MealPlanDetail);
            return Ok(MealPlanDetailDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] MealPlanDetailDTO MealPlanDetailDTO)
        {
            if (ModelState.IsValid)
            {
                MealPlanDetail MealPlanDetail = _mapper.Map<MealPlanDetail>(MealPlanDetailDTO);
                repository.CreateMealPlanDetail(MealPlanDetail);
                
                return Created(Request.GetDisplayUrl(), MealPlanDetailDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{MealPlanID}/{DishId}")]
        public async Task<ActionResult> PutAsync(int MealPlanID, int DishId, [FromBody] MealPlanDetailDTO MealPlanDetailDTO)
        {
            var s = repository.FindMealPlanDetailById(MealPlanID, DishId);
            if (s == null)
            {
                MealPlanDetail MealPlanDetail = _mapper.Map<MealPlanDetail>(MealPlanDetailDTO);
                repository.CreateMealPlanDetail(MealPlanDetail);
            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.Quantity = MealPlanDetailDTO.Quantity;
            repository.UpdateMealPlanDetail(s);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var s = repository.GetMealPlanDetails(id);
            if (s == null || s.Count()==0) return NotFound();
            else
            {
                repository.DeleteMealPlanDetail(id);
                return NoContent();
            }
        }
    }
}
