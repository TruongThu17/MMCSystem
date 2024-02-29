using AutoMapper;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;

namespace MMCSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private IAboutRepository repository = new AboutRepository();
        private IMapper _mapper;

        public AboutController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET api/<AboutController>/5
        [HttpGet]
        public ActionResult Get()
        {
            About a = repository.FindAbout();
            return Ok(a);
        }

        // POST api/<AboutController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
