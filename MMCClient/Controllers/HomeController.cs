using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MMCClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public HomeController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync()
        {
            Home home = new Home();
            var res = await client.GetAsync($"api/about");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            Data.Models.About About = JsonConvert.DeserializeObject<Data.Models.About>(content);
            home.About = About;

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
        public async Task<IActionResult> AboutAsync()
        {
            var res = await client.GetAsync($"api/about");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            Data.Models.About About = JsonConvert.DeserializeObject<Data.Models.About>(content);



            return View(About);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Test()
        {
            // Path to the image in wwwroot
            var imagePath = Path.Combine(_env.WebRootPath, "assets", "img", "intro.jpg");

            // Check if the image file exists
            if (!System.IO.File.Exists(imagePath))
            {
                _logger.LogError($"Image not found: {imagePath}");
                return NotFound();
            }

            // Open the image file as a stream
            using var stream = new FileStream(imagePath, FileMode.Open);

            // Upload the image to Firebase Storage
            try
            {
                await _firebaseStorage.Child("images").Child("intro.jpg").PutAsync(stream);
                _logger.LogInformation("Image uploaded successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error uploading image: {ex.Message}");
                // Handle the error as needed
            }

            // Add your additional logic here

            return View();
        }
    }
}
