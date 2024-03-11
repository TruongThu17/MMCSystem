using Data.DTO;
using Data.Models;
using DataAccess;
using Firebase.Storage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace MMCClient.Controllers
{
    public class AuthenController : Controller
    {

		private readonly HttpClient client;
		public AuthenController()
		{
			client = new() { BaseAddress = new Uri("http://localhost:5000") };
		}
		public IActionResult Index()
        {
            LoginVM login = new LoginVM();
            return View("Login", login);
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Index([Bind("username,password")] LoginVM login)
		{
			var body = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
			var response = await client.PostAsync($"api/Authentication/login", body);

			if (response.IsSuccessStatusCode)
			{
				var responseContent = await response.Content.ReadAsStringAsync();
				var responseObject = JsonConvert.DeserializeObject<ResponseModel>(responseContent);

				// Decode the token
				var handler = new JwtSecurityTokenHandler();
				var jsonToken = handler.ReadToken(responseObject.Bear) as JwtSecurityToken;

				if (jsonToken != null)
				{
					var userPrincipal = new ClaimsPrincipal(new ClaimsIdentity(jsonToken.Claims));
					var roles = userPrincipal.FindAll(ClaimTypes.Role).Select(claim => claim.Value).ToList();
					var userRole = roles.FirstOrDefault();
					if(userRole!=null && (userRole.Equals("SuperAdmin") || userRole.Equals("Admin") || userRole.Equals("Staff") || userRole.Equals("Parents")))
					{
						HttpContext.Session.Set("Role", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(userRole)));
					}
					HttpContext.Session.Set("Username", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(login.username)));
                    HttpContext.Session.SetString("Token", responseObject.Bear);
                    // redirect to home foreach user
                    // Switch case based on user role
                    switch (userRole)
					{
						case "SuperAdmin":
							return RedirectToAction("Index", "SuperAdminHome");

						case "Admin":
							return RedirectToAction("Index", "AdminHome");

						case "Staff":
							return RedirectToAction("StaffHome", "Home");

						case "Parents":
							return RedirectToAction("ParentsHome", "Home");

						default:
							// Handle other roles or scenarios
							return RedirectToAction(nameof(Index), login);
					}
				}

				return RedirectToAction(nameof(Index), login);
			}
			else
			{
				login.message = "Đăng nhập không thành công!";
				return RedirectToAction(nameof(Index), login);
			}
		}
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("Role");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Registrator()
		{
			RegistratorVM registratorVM = new RegistratorVM();
			return View("Registrator", registratorVM);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Registrator([Bind("Username,Password,FullName,Email,Phone,Address,BirthDay,EducationName")] RegistratorVM register)
		{
			// create education
			EducationDTO educationDTO = new EducationDTO()
			{
				Id =0,
				Name = register.EducationName
			};
			var body = new StringContent(JsonConvert.SerializeObject(educationDTO), Encoding.UTF8, "application/json");

			var response = await client.PostAsync($"api/Education", body);

            if (response.IsSuccessStatusCode)
			{
                var content= await response.Content.ReadAsStringAsync();
                educationDTO = JsonConvert.DeserializeObject<EducationDTO>(content);
                RegisterModel user = new RegisterModel
				{
					Username = register.Username,
					Email = register.Email,
					Password = register.Password,
					Status = true,
					FullName = register.FullName,
					Address = register.Address,
					BirthDay = register.BirthDay,
					ParentFullName = "",
					ParentPhone = "",
					Phone = register.Phone,
					EducationId = educationDTO.Id
				};
				var bodyu = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
				var responseu = await client.PostAsync($"api/Authentication/register", bodyu);

				if (responseu.IsSuccessStatusCode)
				{
					return RedirectToAction(nameof(Index));
				}
			}

			return View("Registrator", register);
		}
	}
}
