using Data.DTO;
using Data.Models;
using Firebase.Storage;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MMCClient.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public AboutController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync()
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
        public async Task<IActionResult> EditAsync()
        {
            var res = await client.GetAsync($"api/about/aboutDTO");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            Data.DTO.AboutDTO About = JsonConvert.DeserializeObject<Data.DTO.AboutDTO>(content);

            return View(About);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("ID, Description, Img, ImgFile")] AboutDTO aboutDTO)
        {
            
            if (aboutDTO.ImgFile == null || aboutDTO.ImgFile.Length == 0)
            {
                _logger.LogError("No image file provided.");
                return BadRequest("No image file provided.");
            }

            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(aboutDTO.ImgFile.FileName);

            try
            {
                using (var stream = aboutDTO.ImgFile.OpenReadStream())
                {
                    await _firebaseStorage.Child("about").Child(uniqueFileName).PutAsync(stream);
                }

                _logger.LogInformation($"Image '{uniqueFileName}' uploaded successfully.");
                aboutDTO.Img = $"https://firebasestorage.googleapis.com/v0/b/{_firebaseStorage.StorageBucket}/o/about%2F{uniqueFileName}?alt=media";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error uploading image: {ex.Message}");
                return StatusCode(500, "Error uploading image to Firebase Storage.");
            }
            About about = new About()
            {
                ID = aboutDTO.ID,
                Img = aboutDTO.Img,
                Description = aboutDTO.Description
            };
            var body = new StringContent(JsonConvert.SerializeObject(about), Encoding.UTF8, "application/json");
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PutAsync($"api/About", body);
                if (response.IsSuccessStatusCode) return RedirectToAction(nameof(Index));
                else return StatusCode(500);
           
        }
      

    }
}
