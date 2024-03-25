using AutoMapper;
using Data.DTO;
using Data.Models;
using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace MMCSystemAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierRepository repository = new SupplierRepository();
        private readonly UserManager<User> _userManager;
        private IMapper _mapper;

        public SupplierController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpGet("{search?}")]
        public async Task<ActionResult<IEnumerable<SupplierDTO>>> GetAsync(string? search)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<Supplier> Supplier = repository.GetSuppliers((int)user.EducationId);
            IEnumerable<SupplierDTO> SupplierDTO = _mapper.Map<IEnumerable<SupplierDTO>>(Supplier);
            if (search != null)
            {
                SupplierDTO = SupplierDTO.Where(x => x.SupplierName.ToLower().Contains(search.ToLower())
                                            || x.Email.ToLower().Contains(search.ToLower())
                                            || x.Phone.ToLower().Contains(search.ToLower())).ToList();
            }
            
            return Ok(SupplierDTO);
        }

        [HttpGet("find/{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Supplier Supplier = repository.FindSupplierById(id);
            if (Supplier == null) return NotFound();
            SupplierDTO SupplierDTO = _mapper.Map<SupplierDTO>(Supplier);
            return Ok(SupplierDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] SupplierDTO SupplierDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);

                var user = await _userManager.FindByNameAsync(usernameClaim.Value);

                Supplier Supplier = _mapper.Map<Supplier>(SupplierDTO);
                Supplier.EducationId = user.EducationId;
                repository.CreatSupplier(Supplier);
                SupplierDTO.SupplierId = Supplier.SupplierId;
                return Created(Request.GetDisplayUrl(), SupplierDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] SupplierDTO SupplierDTO)
        {
            var s = repository.FindSupplierById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.SupplierName = SupplierDTO.SupplierName;
            s.Phone = SupplierDTO.Phone;
            s.Email = SupplierDTO.Email;
            repository.UpdateSupplier(s);
            return NoContent();
        }
        
    }
}
