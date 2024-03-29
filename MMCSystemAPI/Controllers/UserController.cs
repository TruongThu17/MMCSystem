﻿using AutoMapper;
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
        private IClassRepository classRepository = new ClassRepository();
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
        [HttpGet("getByUserNameStudent/{username}")]
        public async Task<ActionResult<AccountAdminDTO>> GetStudent(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            AccountStudentDTO c = _mapper.Map<AccountStudentDTO>(user);
            return Ok(c);
        }
        [HttpGet("getByEmail/{email}")]
		public async Task<ActionResult<AccountAdminDTO>> GetByEmail(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
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
                                                    ).ToList();
            }

            var users = usersQuery;

            IEnumerable<AccountAdminDTO> c = _mapper.Map<IEnumerable<AccountAdminDTO>>(users);
            foreach (var item in c)
            {
                if (item.EducationId != null)
                    item.EducationName = eduRepository.FindEducationById((int)item.EducationId).Name;
            }
            return Ok(c);
        }
        [HttpGet("listAccountStudent/{search?}")]
        public async Task<ActionResult<IEnumerable<AccountStudentDTO>>> GetStudentAccount(string? search)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(usernameClaim.Value);

            var studentRoleName = "Student";
            var users = await _userManager.GetUsersInRoleAsync(studentRoleName);

            IEnumerable<AccountStudentDTO> StudentList = _mapper.Map<IEnumerable<AccountStudentDTO>>(users);
            StudentList = StudentList.Where(x => x.EducationId == (int)user.EducationId).ToList();
            foreach (var item in StudentList)
            {
                if (item.EducationId != null)
                    item.EducationName = eduRepository.FindEducationById((int)item.EducationId).Name;
                if(item.ClassId != null)
                {
                    item.ClassName = classRepository.FindClassById((int) item.ClassId).ClassName;
                }
            }
            if(search != null)
            {
                StudentList = StudentList.Where(u => (u.FullName != null && u.FullName.ToLower().Contains(search.ToLower()))
                                                    || (u.Email != null && u.Email.ToLower().Contains(search.ToLower()))
                                                    || (u.Address != null && u.Address.ToLower().Contains(search.ToLower()))
                                                    ).ToList();
            }

            return Ok(StudentList);
        }

       
    }
}
