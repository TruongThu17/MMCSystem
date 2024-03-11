using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;
using System.Reflection.Metadata;

namespace MMCSystemAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EducationController : ControllerBase
	{
		private IEducationRepository repository = new EducationRepository();
		private IMapper _mapper;

		public EducationController(IMapper mapper)
		{
			_mapper = mapper;
		}


		[HttpGet]
		[Authorize(Roles = "SuperAdmin, Admin")]
		public ActionResult<IEnumerable<EducationDTO>> Get()
		{
			IEnumerable<Education> edus = repository.GetEducations();
			IEnumerable<EducationDTO> eduDTOs = _mapper.Map<IEnumerable<EducationDTO>>(edus);
			return Ok(eduDTOs);
		}
		[HttpGet("{id}")]
		[Authorize(Roles = "SuperAdmin, Admin")]
		public ActionResult Get(int id)
		{
			if (id == null) return BadRequest();
			Education edu = repository.FindEducationById(id);
			if (edu == null) return NotFound();
			EducationDTO eduDTO = _mapper.Map<EducationDTO>(edu);
			return Ok(eduDTO);
		}
		[HttpPost]
		public ActionResult Post([FromBody] EducationDTO eduDTO)
		{
			if (ModelState.IsValid)
			{
				Education edu = _mapper.Map<Education>(eduDTO);
				repository.CreateEducation(edu);
				eduDTO.Id = edu.Id;
				return Created(Request.GetDisplayUrl(), eduDTO);
			}
			return BadRequest(ModelState);
		}
		[HttpPut("{id}")]
		[Authorize(Roles = "SuperAdmin, Admin")]
		public ActionResult Put(int id, [FromBody] EducationDTO eduDTO)
		{
			var s = repository.FindEducationById(id);
			if (s == null) return NotFound();
			if (!ModelState.IsValid) return BadRequest(ModelState);
			s.Name = eduDTO.Name;
			repository.UpdateEducation(s);
			return NoContent();
		}
	}
}
