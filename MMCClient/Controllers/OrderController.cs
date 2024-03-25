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
    public class OrderController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public OrderController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
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
            PageSz<OrderDTO> page = new PageSz<OrderDTO>();
            page.PageSize = 10;
            List<OrderDTO> OrderDTOs = new List<OrderDTO>();
            var resclass = await client.GetAsync("api/Order");
            var contentclass = await resclass.Content.ReadAsStringAsync();

            if (!resclass.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            OrderDTOs = JsonConvert.DeserializeObject<List<OrderDTO>>(contentclass);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)OrderDTOs.Count / page.PageSize);
            List<OrderDTO> paginateds = OrderDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = OrderDTOs.Count();
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
            var resmt = await client.GetAsync("api/MealPlan");
            var contentmt = await resmt.Content.ReadAsStringAsync();

            if (!resmt.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealPLanDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealPLanDTO>>(contentmt);
            var MealPLanSelectList = new SelectList(MealTypeDTOs, "MealPlanID", "MealPlanName");
            ViewBag.MealPLanSelectList = MealPLanSelectList;

            var rest = await client.GetAsync("api/Class");
            var contentt = await rest.Content.ReadAsStringAsync();

            if (!rest.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassDTO>>(contentt);
            var ClassDTOSelectList = new SelectList(ClassDTOs, "ClassId", "ClassName");
            ViewBag.ClassDTOSelectList = ClassDTOSelectList;
            OrderDTO c = new OrderDTO();
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Quantity,Date,Note,MealPlanId,ClassId")] OrderDTO OrderDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(OrderDTO), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"api/Order", body);

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
            var resmt = await client.GetAsync("api/MealPlan");
            var contentmt = await resmt.Content.ReadAsStringAsync();

            if (!resmt.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealPLanDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealPLanDTO>>(contentmt);
            var MealPLanSelectList = new SelectList(MealTypeDTOs, "MealPlanID", "MealPlanName");
            ViewBag.MealPLanSelectList = MealPLanSelectList;

            var rest = await client.GetAsync("api/Class");
            var contentt = await rest.Content.ReadAsStringAsync();

            if (!rest.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassDTO>>(contentt);
            var ClassDTOSelectList = new SelectList(ClassDTOs, "ClassId", "ClassName");
            ViewBag.ClassDTOSelectList = ClassDTOSelectList;

            var reso = await client.GetAsync("api/order/"+id);
            var contento = await reso.Content.ReadAsStringAsync();

            if (!reso.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            OrderDTO OrderDTO = JsonConvert.DeserializeObject<OrderDTO>(contento);
            return View(OrderDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("OrderId,Quantity,Date,Note,MealPlanId,ClassId")] OrderDTO OrderDTO)
        {

            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var body = new StringContent(JsonConvert.SerializeObject(OrderDTO), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/Order/{OrderDTO.OrderId}", body);

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
