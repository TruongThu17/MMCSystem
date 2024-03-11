using Data.DTO;
using Data.Models;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;

namespace MMCClient.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public AccountController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> AdminList(int? pageNumber, string? search)
        {

            PageSz<AccountAdminDTO> page = new PageSz<AccountAdminDTO>();
            List<AccountAdminDTO> list = new List<AccountAdminDTO>();
            if (search == null)
            {
                var res = await client.GetAsync("api/User/listAccountAdmin");
                var content = await res.Content.ReadAsStringAsync();

                if (!res.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                list = JsonConvert.DeserializeObject<List<AccountAdminDTO>>(content);
            }
            else
            {
                var res = await client.GetAsync("api/User/listAccountAdmin/" + search);
                var content = await res.Content.ReadAsStringAsync();

                if (!res.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                list = JsonConvert.DeserializeObject<List<AccountAdminDTO>>(content);
                page.searchString = search;
            }


            page.PageSize = 8;
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)list.Count / page.PageSize);
            List<AccountAdminDTO> paginated = list.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginated;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = list.Count;

            return View("AdminList", page);
        }
        public async Task<IActionResult> EditAdmin(string username)
        {
            var res = await client.GetAsync($"api/User/getByUserName/" + username);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            AccountAdminDTO AccountAdminDTO = JsonConvert.DeserializeObject<AccountAdminDTO>(content);

            return View(AccountAdminDTO);
        }
    }
}
