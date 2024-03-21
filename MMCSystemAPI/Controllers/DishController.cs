using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Security.Claims;

namespace MMCSystemAPI.Controllers
{
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
    }
}
