using Data.DTO;
using Data.Models;
using Data.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MMCSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<User> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginVM model)
        {
            var user = await _userManager.FindByNameAsync(model.username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var Bear = GetToken(authClaims);
                ResponseModel respone = new ResponseModel();
                respone.Bear = new JwtSecurityTokenHandler().WriteToken(Bear);
                respone.Expiration = Bear.ValidTo;

				return Ok(respone);
            }

            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            User user = new User
            {
                Id = Guid.NewGuid(),
                UserName = model.Username,
                NormalizedUserName = "ADMIN",
                Email = model.Email,
                NormalizedEmail = model.Email,
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, model.Password),
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                Status = true,
                FullName = model.FullName,
                Address = model.Address,
                BirthDay = model.BirthDay,
                ParentFullName = model.ParentFullName,
                ParentPhone = model.ParentPhone,
                Phone = model.Phone
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
            var roleExists = await _roleManager.RoleExistsAsync("Admin");
            if (!roleExists)
            {
                // Role does not exist, create it
                var role = new IdentityRole<Guid>("Admin");
                var roleResult = await _roleManager.CreateAsync(role);

                if (!roleResult.Succeeded)
                {
                    // Handle error when role creation fails
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Role creation failed!" });
                }
            }
            var addToRoleResult = await _userManager.AddToRoleAsync(user, "Admin");

            if (!addToRoleResult.Succeeded)
            {
                // Handle error when adding user to role fails
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Adding user to role failed!" });
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
