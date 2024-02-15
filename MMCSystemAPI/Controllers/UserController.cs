using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
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
        private IUserRepository repository = new UserRepository();
        private IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<StudentProfileDTO>> Get()
        {
            IEnumerable<User> cus = repository.GetUsers();
            IEnumerable<StudentProfileDTO> c = _mapper.Map<IEnumerable<StudentProfileDTO>>(cus);
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
