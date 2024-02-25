using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using System.Diagnostics;

namespace MMCClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;
        public HomeController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
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
