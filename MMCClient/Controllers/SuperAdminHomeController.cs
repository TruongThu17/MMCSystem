using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Index()
		{
			return View();
		}
	}
}
