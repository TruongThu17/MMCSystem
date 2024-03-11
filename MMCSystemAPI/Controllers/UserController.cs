using AutoMapper;
using Data.DTO;
using Data.Models;
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
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        private IUserRepository repository = new UserRepository();
        private IEducationRepository eduRepository = new EducationRepository();
        private IMapper _mapper;

        public UserController(IMapper mapper, UserManager<User> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }


        [HttpGet]
        public ActionResult<IEnumerable<StudentProfileDTO>> Get()
        {
            IEnumerable<User> cus = repository.GetUsers();
            IEnumerable<StudentProfileDTO> c = _mapper.Map<IEnumerable<StudentProfileDTO>>(cus);
            return Ok(c);
        }
        [HttpGet("getByUserName/{username}")]
        public async Task<ActionResult<AccountAdminDTO>> Get(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            AccountAdminDTO c = _mapper.Map<AccountAdminDTO>(user);
            return Ok(c);
        }
        [HttpGet("listAccountAdmin")]
        public async Task<ActionResult<IEnumerable<AccountAdminDTO>>> GetAdminAccount()
        {
            var adminRoleName = "Admin"; 
            var users = await _userManager.GetUsersInRoleAsync(adminRoleName);
            
            IEnumerable<AccountAdminDTO> AdminList = _mapper.Map<IEnumerable<AccountAdminDTO>>(users);
            foreach (var item in AdminList)
            {
                if(item.EducationId!=null)
                item.EducationName = eduRepository.FindEducationById((int)item.EducationId).Name;
            }
            return Ok(AdminList);
        }
        [HttpGet("listAccountAdmin/{search}")]
        public async Task<ActionResult<IEnumerable<AccountAdminDTO>>> GetAdminAccount(string? search)
        {
            var adminRoleName = "Admin";
            var usersQuery = await _userManager.GetUsersInRoleAsync(adminRoleName);

            // Apply filters based on parameters
            if (!string.IsNullOrEmpty(search))
            {
                usersQuery = usersQuery.Where(u => (u.FullName != null && u.FullName.ToLower().Contains(search.ToLower()))
                                                    || (u.Email != null && u.Email.ToLower().Contains(search.ToLower()))
                                                    || (u.Address != null && u.Address.ToLower().Contains(search.ToLower()))
                                                    || (u.Phone != null && u.Phone.Contains(search))
                                                    ).ToList();
            }

            var users = usersQuery;

            IEnumerable<AccountAdminDTO> c = _mapper.Map<IEnumerable<AccountAdminDTO>>(users);

            return Ok(c);
        }


        //[HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    if (id == null) return BadRequest();
        //    Customer cus = repository.FindCustomerById(id);
        //    if (cus == null) return NotFound();
        //    CustomerVM c = _mapper.Map<CustomerVM>(cus);
        //    return Ok(c);
        //}

        //// PUT api/<SupplierController>/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] CustomerVM customerDTO)
        //{

        //    var s = repository.FindCustomerById(id);
        //    if (s == null) return NotFound();
        //    if (!ModelState.IsValid) return BadRequest(ModelState);
        //    Customer cus = _mapper.Map<Customer>(customerDTO);
        //    cus.UserId = s.UserId;
        //    repository.UpdateCustomer(cus);
        //    return NoContent();
        //}
    }
}
