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
    public class OrderController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private IOrderRepository repository = new OrderRepository();
        private IMapper _mapper;

        public OrderController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetAsync()
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);

            var user = await _userManager.FindByNameAsync(usernameClaim.Value);
            IEnumerable<Order> ct = repository.GetOrders((int)user.EducationId);
            IEnumerable<OrderDTO> ctDTO = _mapper.Map<IEnumerable<OrderDTO>>(ct);
            return Ok(ctDTO);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == null) return BadRequest();
            Order Order = repository.FindOrderById(id);
            if (Order == null) return NotFound();
            OrderDTO OrderDTO = _mapper.Map<OrderDTO>(Order);
            return Ok(OrderDTO);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] OrderDTO OrderDTO)
        {
            if (ModelState.IsValid)
            {
                var usernameClaim = User.FindFirst(ClaimTypes.Name);

                var user = await _userManager.FindByNameAsync(usernameClaim.Value);
                Order order = _mapper.Map<Order>(OrderDTO);
                order.EducationId = (int)user.EducationId;
                repository.CreateOrder(order);
                OrderDTO.OrderId = order.OrderId;
                return Created(Request.GetDisplayUrl(), OrderDTO);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderDTO OrderDTO)
        {
            var s = repository.FindOrderById(id);
            if (s == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            s.Quantity = OrderDTO.Quantity;
            s.ClassId = OrderDTO.ClassId;
            s.Date = OrderDTO.Date;
            s.Note = OrderDTO.Note;
            s.MealPlanId = OrderDTO.MealPlanId;
            repository.UpdateOrder(s);
            return NoContent();
            }
        }
}
