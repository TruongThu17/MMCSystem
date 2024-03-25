using Data.DTO;
using Data.Models;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MMCClient.Controllers
{
    public class MealTypeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public MealTypeController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync(int? pageNumber)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            PageSz<MealTypeDTO> page = new PageSz<MealTypeDTO>();
            page.PageSize = 10;
            List<MealTypeDTO> MealTypeDTOs = new List<MealTypeDTO>();
            var resclass = await client.GetAsync("api/MealType");
            var contentclass = await resclass.Content.ReadAsStringAsync();

            if (!resclass.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            MealTypeDTOs = JsonConvert.DeserializeObject<List<MealTypeDTO>>(contentclass);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)MealTypeDTOs.Count / page.PageSize);
            List<MealTypeDTO> paginateds = MealTypeDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = MealTypeDTOs.Count();
            return View(page);
        }
        public async Task<IActionResult> CreateAsync()
        {
            MealTypeDTO c = new MealTypeDTO();
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Name")] MealTypeDTO MealTypeDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(MealTypeDTO), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"api/MealType", body);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return StatusCode(500);
            }
        }
        public async Task<IActionResult> EditAsync(int id)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var resd = await client.GetAsync("api/MealType/" + id);
            var contentd = await resd.Content.ReadAsStringAsync();

            if (!resd.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            MealTypeDTO c = JsonConvert.DeserializeObject<MealTypeDTO>(contentd);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("Id,Name")] MealTypeDTO MealTypeDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(MealTypeDTO), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/MealType/{MealTypeDTO.Id}" , body);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
