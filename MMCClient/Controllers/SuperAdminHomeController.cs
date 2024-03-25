using Data.DTO;
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
            var resblog = await client.GetAsync($"api/blog");
            var contentblog = await resblog.Content.ReadAsStringAsync();

            if (!resblog.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            List<Data.Models.Blog> blogs = JsonConvert.DeserializeObject<List<Data.Models.Blog>>(contentblog);
            List<Data.Models.Blog> top5Blogs = blogs.OrderBy(admin => admin.ID).Take(5).ToList();
            home.Blogs = top5Blogs;
            home.CountBlog = blogs.Count;
                var res = await client.GetAsync("api/User/listAccountAdmin");
                var content = await res.Content.ReadAsStringAsync();

                if (!res.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

            List<AccountAdminDTO> list = JsonConvert.DeserializeObject<List<AccountAdminDTO>>(content);
            List<AccountAdminDTO> top5Admins = list.OrderBy(admin => admin.Username).Take(8).ToList();
            home.Accounts = top5Admins;
            home.CountAcc = list.Count;
            return View(home);
		}
	}
}
