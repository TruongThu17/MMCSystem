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
    public class SupplierController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public SupplierController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
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
            PageSz<SupplierDTO> page = new PageSz<SupplierDTO>();
            page.PageSize = 10;
            List<SupplierDTO> SupplierDTOs = new List<SupplierDTO>();
            var res = await client.GetAsync("api/Supplier/"+search);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            SupplierDTOs = JsonConvert.DeserializeObject<List<SupplierDTO>>(content);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)SupplierDTOs.Count / page.PageSize);
            List<SupplierDTO> paginateds = SupplierDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = SupplierDTOs.Count();
            page.searchString = search;
            return View(page);
        }
        public async Task<IActionResult> CreateAsync()
        {
            SupplierDTO c = new SupplierDTO();
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("SupplierName,Email, Phone")] SupplierDTO SupplierDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var body = new StringContent(JsonConvert.SerializeObject(SupplierDTO), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"api/Supplier", body);

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
            var res = await client.GetAsync($"api/Supplier/find/" + id);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            SupplierDTO c = JsonConvert.DeserializeObject<SupplierDTO>(content);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("SupplierId,SupplierName,Email, Phone")] SupplierDTO SupplierDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var body = new StringContent(JsonConvert.SerializeObject(SupplierDTO), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/Supplier/{SupplierDTO.SupplierId}", body);

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
