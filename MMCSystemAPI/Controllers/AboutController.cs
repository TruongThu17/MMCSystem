using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Data;
using System.Security.Claims;

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
        [HttpGet("aboutDTO")]
        public ActionResult GetAboutDTO()
        {
            About a = repository.FindAbout();
            AboutDTO aDTO = _mapper.Map<AboutDTO>(a);
            return Ok(aDTO);
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpPut]
        public ActionResult Put([FromBody] About about)
        {
            var a = repository.FindAbout();
            if (a == null) repository.CreateAbout(about);
            else repository.UpdateAbout(about);
            return Ok(about);
        }

    }
}
