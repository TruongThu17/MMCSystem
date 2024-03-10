using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;

namespace MMCClient.Controllers
{
	public class SuperAdminHomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly FirebaseStorage _firebaseStorage;
		private readonly IWebHostEnvironment _env;

		private readonly HttpClient client;
		public SuperAdminHomeController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
		{
			_firebaseStorage = firebaseStorage;
			_logger = logger;
			_env = env;

			client = new() { BaseAddress = new Uri("http://localhost:5000") };
		}
		public async Task<IActionResult> IndexAsync()
		{
			HomeSP home = new HomeSP();
            var resblog = await client.GetAsync($"api/blog/Top4");
            var contentblog = await resblog.Content.ReadAsStringAsync();

            if (!resblog.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            List<Data.Models.Blog> blogs = JsonConvert.DeserializeObject<List<Data.Models.Blog>>(contentblog);
            home.Blogs = blogs;
            return View(home);
		}
	}
}
