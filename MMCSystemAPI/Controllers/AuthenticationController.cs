using Data.DTO;
using Data.Models;
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
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            // Đặt múi giờ cho thời gian hết hạn là UTC
            var expirationTimeUtc = DateTime.UtcNow.AddHours(3000);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }

        [HttpPost]
        [Route("registerStudent")]
        public async Task<IActionResult> RegisterStudent([FromBody] RegisterModel model)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);

            var usere = await _userManager.FindByNameAsync(usernameClaim.Value);

            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            User user = new User
            {
                Id = Guid.NewGuid(),
                UserName = model.Username,
                NormalizedUserName = model.Username,
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
                EducationId = (int) usere.EducationId,
                ClassId = model.ClassId
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
            var roleExists = await _roleManager.RoleExistsAsync("Student");
            if (!roleExists)
            {
                // Role does not exist, create it
                var role = new IdentityRole<Guid>("Student");
                var roleResult = await _roleManager.CreateAsync(role);

                if (!roleResult.Succeeded)
                {
                    // Handle error when role creation fails
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Role creation failed!" });
                }
            }
            var addToRoleResult = await _userManager.AddToRoleAsync(user, "Student");

            if (!addToRoleResult.Succeeded)
            {
                // Handle error when adding user to role fails
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Adding user to role failed!" });
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
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
                NormalizedUserName = model.Username,
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
                EducationId = model.EducationId
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
        [HttpPost]
        [Route("updateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] RegisterModel model)
        {
            // Tìm kiếm người dùng theo username
            var user = await _userManager.FindByNameAsync(model.Username);

            // Kiểm tra xem người dùng có tồn tại không
            if (user == null)
            {
                // Trả về lỗi nếu không tìm thấy người dùng
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Error", Message = "User not found!" });
            }
            user.Email = model.Email;
            user.FullName = model.FullName;
            user.Address = model.Address;
            user.BirthDay = model.BirthDay;
            user.ParentFullName = model.ParentFullName;
            user.ClassId = model.ClassId;

            // Lưu thay đổi vào cơ sở dữ liệu
            var result = await _userManager.UpdateAsync(user);

            // Kiểm tra kết quả của việc cập nhật
            if (!result.Succeeded)
            {
                // Trả về lỗi nếu việc cập nhật thất bại
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User update failed!" });
            }

            // Trả về phản hồi thành công nếu mọi thứ đều hợp lệ
            return Ok(new Response { Status = "Success", Message = "User updated successfully!" });
        }

    }
}
