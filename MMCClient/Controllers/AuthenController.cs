using Data.ViewModel;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

					var userRole = jsonToken.Claims.FirstOrDefault()?.Value;
					if(userRole!=null && (userRole.Equals("SuperAdmin") || userRole.Equals("Admin") || userRole.Equals("Staff") || userRole.Equals("Parents")))
					{
						HttpContext.Session.Set("Role", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(userRole)));
					}
					HttpContext.Session.Set("Username", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(login.username)));

					// redirect to home foreach user
					// Switch case based on user role
					switch (userRole)
					{
						case "SuperAdmin":
							return RedirectToAction("Index", "SuperAdminHome");

						case "Admin":
							return RedirectToAction("AdminHome", "Home");

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


	}
}
