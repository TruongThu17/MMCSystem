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
    public class MealPlanController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public MealPlanController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
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

            PageSz<MealPLanDTO> page = new PageSz<MealPLanDTO>();
            page.PageSize = 10;
            List<MealPLanDTO> MealPLanDTOs = new List<MealPLanDTO>();
            var resclass = await client.GetAsync("api/MealPlan");
            var contentclass = await resclass.Content.ReadAsStringAsync();

            if (!resclass.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            MealPLanDTOs = JsonConvert.DeserializeObject<List<MealPLanDTO>>(contentclass);
            if(search !=null) {

            MealPLanDTOs = MealPLanDTOs.Where(x => x.MealPlanName.ToLower().Contains(search.ToLower())
                                            ||x.Description.ToLower().Contains(search.ToLower())
                                            || x.ClassType.ClassTypeName.ToLower().Contains(search.ToLower())
                                            || x.MealType.Name.ToLower().Contains(search.ToLower())
                                            ).ToList();
            }

            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)MealPLanDTOs.Count / page.PageSize);
            List<MealPLanDTO> paginateds = MealPLanDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = MealPLanDTOs.Count();
            page.searchString = search;
            return View(page);
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

            var res = await client.GetAsync("api/ClassType");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassTypeDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassTypeDTO>>(content);
            var classTypeSelectList = new SelectList(ClassDTOs, "ClassTypeId", "ClassTypeName");
            ViewBag.ClassTypeSelectList = classTypeSelectList;

            var resmt = await client.GetAsync("api/MealType");
            var contentmt = await resmt.Content.ReadAsStringAsync();

            if (!resmt.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealTypeDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealTypeDTO>>(contentmt);
            var MealTypeSelectList = new SelectList(MealTypeDTOs, "Id", "Name");
            ViewBag.MealTypeSelectList = MealTypeSelectList;

            var resml = await client.GetAsync("api/MealPlan/"+id);
            var contentml = await resml.Content.ReadAsStringAsync();

            if (!resml.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            MealPLanDTO MealPLanDTO = JsonConvert.DeserializeObject<MealPLanDTO>(contentml);
            ViewBag.Token = token;
            return View(MealPLanDTO);
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

            var res = await client.GetAsync("api/ClassType");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassTypeDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassTypeDTO>>(content);
            var classTypeSelectList = new SelectList(ClassDTOs, "ClassTypeId", "ClassTypeName");
            ViewBag.ClassTypeSelectList = classTypeSelectList;

            var resmt = await client.GetAsync("api/MealType");
            var contentmt = await resmt.Content.ReadAsStringAsync();

            if (!resmt.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<MealTypeDTO> MealTypeDTOs = JsonConvert.DeserializeObject<List<MealTypeDTO>>(contentmt);
            var MealTypeSelectList = new SelectList(MealTypeDTOs, "Id", "Name");
            ViewBag.MealTypeSelectList = MealTypeSelectList;


            MealPLanDTO MealPLanDTO = new MealPLanDTO();
            ViewBag.Token = token;
            return View(MealPLanDTO);
        }
    }
}
