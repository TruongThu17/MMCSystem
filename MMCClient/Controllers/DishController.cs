using Data.DTO;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MMCClient.Controllers
{
    public class DishController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public DishController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync(int? pageNumber, string? search)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            PageSz<DishDTO> page = new PageSz<DishDTO>();
            page.PageSize = 10;
            List<DishDTO> DishDTOs = new List<DishDTO>();
            var resclass = await client.GetAsync("api/Dish/" + search);
            var contentclass = await resclass.Content.ReadAsStringAsync();

            if (!resclass.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            DishDTOs = JsonConvert.DeserializeObject<List<DishDTO>>(contentclass);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)DishDTOs.Count / page.PageSize);
            List<DishDTO> paginateds = DishDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.searchString = search;
            return View(page);
        }
        public async Task<IActionResult> CreateAsync()
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await client.GetAsync("api/MealType");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealTypeDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealTypeDTO>>(content);
            DishDTO c = new DishDTO();
            var MealTypeSelectList = new SelectList(MealTypeDTOs, "Id", "Name");
            ViewBag.MealTypeSelectList = MealTypeSelectList;
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("DishName,Description,Nutrition,MealTypeId")] DishDTO DishDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(DishDTO), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"api/Dish", body);

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

            var res = await client.GetAsync("api/MealType");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealTypeDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealTypeDTO>>(content);
            var MealTypeSelectList = new SelectList(MealTypeDTOs, "Id", "Name");
            ViewBag.MealTypeSelectList = MealTypeSelectList;


            var resd = await client.GetAsync("api/Dish/find/" + id);
            var contentd = await resd.Content.ReadAsStringAsync();

            if (!resd.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            DishDTO c = JsonConvert.DeserializeObject<DishDTO>(contentd);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("DishId,DishName,Description,Nutrition,MealTypeId")] DishDTO DishDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(DishDTO), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/Dish/"+ DishDTO.DishId, body);

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
