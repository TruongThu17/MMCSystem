using Data.DTO;
using Data.Models;
using DataAccess;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MMCClient.Controllers
{
    public class AdminHomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public AdminHomeController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync()
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HomeA home = new HomeA();
            var res = await client.GetAsync("api/User/listAccountStudent");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            List<AccountStudentDTO> list = JsonConvert.DeserializeObject<List<AccountStudentDTO>>(content);
            List<AccountStudentDTO> top8 = list.OrderBy(admin => admin.Username).Take(8).ToList();
            home.Accounts = top8;
            home.CountAcc = list.Count;

            var resS = await client.GetAsync("api/Supplier");
            var contents = await resS.Content.ReadAsStringAsync();

            if (!resS.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            List<SupplierDTO>  SupplierDTOs = JsonConvert.DeserializeObject<List<SupplierDTO>>(contents);
            home.CountSup = SupplierDTOs.Count;
            List<SupplierDTO> top8s = SupplierDTOs.OrderBy(admin => admin.SupplierId).Take(8).ToList();
            home.Suppliers = top8s;

            List<OrderDTO> OrderDTOs = new List<OrderDTO>();
            var resclass = await client.GetAsync("api/Order");
            var contentclass = await resclass.Content.ReadAsStringAsync();

            if (!resclass.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            OrderDTOs = JsonConvert.DeserializeObject<List<OrderDTO>>(contentclass);
            home.CountOrder = OrderDTOs.Sum(x => x.Quantity);
            List < OrderDTO > top8order = OrderDTOs.OrderBy(admin => admin.Date).Take(8).ToList();
            home.Orders = top8order;

            List<IngredientDTO> IngredientDTOs = new List<IngredientDTO>();
            var resi = await client.GetAsync("api/Ingredient");
            var contenti = await resi.Content.ReadAsStringAsync();

            if (!resi.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            DateTime current = DateTime.Now;
            IngredientDTOs = JsonConvert.DeserializeObject<List<IngredientDTO>>(contenti);
            var ingredientsInCurrentMonth = IngredientDTOs.Where(ingredient => ingredient.DateImport.Month == current.Month && ingredient.DateImport.Year == current.Year).ToList();
            home.Month = ingredientsInCurrentMonth.Sum(x => x.Price * x.UnitImport);


            var ingredientsInCurrentDay = IngredientDTOs.Where(ingredient => ingredient.DateImport.Month == current.Month && ingredient.DateImport.Year == current.Year && ingredient.DateImport.Day == current.Day).ToList();
            home.Day = ingredientsInCurrentDay.Sum(x => x.Price * x.UnitImport);
            return View(home);
        }
    }
}
