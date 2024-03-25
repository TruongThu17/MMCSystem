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
    public class IngredientController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public IngredientController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
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
            PageSz<IngredientDTO> page = new PageSz<IngredientDTO>();
            page.PageSize = 10;
            List<IngredientDTO> IngredientDTOs = new List<IngredientDTO>();
            var res = await client.GetAsync("api/Ingredient/" + search);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            IngredientDTOs = JsonConvert.DeserializeObject<List<IngredientDTO>>(content);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)IngredientDTOs.Count / page.PageSize);
            List<IngredientDTO> paginateds = IngredientDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = IngredientDTOs.Count();
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
            var res = await client.GetAsync("api/Supplier");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<SupplierDTO> SupplierDTOs = JsonConvert.DeserializeObject<List<SupplierDTO>>(content);
            var SupplierSelectList = new SelectList(SupplierDTOs, "SupplierId", "SupplierName");
            ViewBag.SupplierSelectList = SupplierSelectList;

            IngredientDTO c = new IngredientDTO();
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("IngredientName,Price, UnitInStock,UnitImport,Unit,DateImport,SupplierId")] IngredientDTO IngredientDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var body = new StringContent(JsonConvert.SerializeObject(IngredientDTO), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"api/Ingredient", body);

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
            var res = await client.GetAsync("api/Supplier");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<SupplierDTO> SupplierDTOs = JsonConvert.DeserializeObject<List<SupplierDTO>>(content);
            var SupplierSelectList = new SelectList(SupplierDTOs, "SupplierId", "SupplierName");
            ViewBag.SupplierSelectList = SupplierSelectList;

            var resIngredient = await client.GetAsync("api/Ingredient/find/"+id);
            var contentIngredient = await resIngredient.Content.ReadAsStringAsync();

            if (!resIngredient.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            IngredientDTO c = JsonConvert.DeserializeObject<IngredientDTO>(contentIngredient);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("IngredientId,IngredientName,Price, UnitInStock,UnitImport,Unit,DateImport,SupplierId")] IngredientDTO IngredientDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var body = new StringContent(JsonConvert.SerializeObject(IngredientDTO), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/Ingredient/"+ IngredientDTO.IngredientId , body);

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
