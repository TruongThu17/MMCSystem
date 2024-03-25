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
    public class IngredientController : ControllerBase
    {
        private IIngredientRepository repository = new IngredientRepository();
        private readonly UserManager<User> _userManager;
        private IMapper _mapper;

        public IngredientController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpGet("{search?}")]
        public async Task<ActionResult<IEnumerable<IngredientDTO>>> GetAsync(string? search)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<Ingredient> Ingredient = repository.GetIngredients((int)user.EducationId);
            IEnumerable<IngredientDTO> IngredientDTO = _mapper.Map<IEnumerable<IngredientDTO>>(Ingredient);
            if (search != null)
            {
                IngredientDTO = IngredientDTO.Where(x => x.IngredientName.ToLower().Contains(search.ToLower())
                                            || x.Supplier.SupplierName.ToLower().Contains(search.ToLower())).ToList();
            }

            return Ok(IngredientDTO);
        }

        [HttpGet("find/{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Ingredient Ingredient = repository.FindIngredientById(id);
            if (Ingredient == null) return NotFound();
            IngredientDTO IngredientDTO = _mapper.Map<IngredientDTO>(Ingredient);
            return Ok(IngredientDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] IngredientDTO IngredientDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);

                var user = await _userManager.FindByNameAsync(usernameClaim.Value);

                Ingredient Ingredient = _mapper.Map<Ingredient>(IngredientDTO);
                Ingredient.EducationId = user.EducationId;
                repository.CreatIngredient(Ingredient);
                Ingredient.IngredientId = IngredientDTO.IngredientId;
                return Created(Request.GetDisplayUrl(), IngredientDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] IngredientDTO IngredientDTO)
        {
            var s = repository.FindIngredientById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.IngredientName = IngredientDTO.IngredientName;
            s.Unit = IngredientDTO.Unit;
            s.UnitImport = IngredientDTO.UnitImport;
            s.DateImport = IngredientDTO.DateImport;
            s.SupplierId = IngredientDTO.SupplierId;
            s.Price = IngredientDTO.Price;
            s.UnitInStock = IngredientDTO.UnitInStock;
            repository.UpdateIngredient(s);
            return NoContent();
        }

    }
}
