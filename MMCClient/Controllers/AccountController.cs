using Data.DTO;
using Data.Models;
using DataAccess;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

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
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
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
            page.searchString = search;
            return View("AdminList", page);
        }
        public async Task<IActionResult> StudentList(int? pageNumber, string? search)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            PageSz<AccountStudentDTO> page = new PageSz<AccountStudentDTO>();
            List<AccountStudentDTO> list = new List<AccountStudentDTO>();
            var res = await client.GetAsync("api/User/listAccountStudent/"+ search);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            list = JsonConvert.DeserializeObject<List<AccountStudentDTO>>(content);


            page.PageSize = 8;
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)list.Count / page.PageSize);
            List<AccountStudentDTO> paginated = list.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginated;
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = list.Count;
            page.searchString = search;
            return View("StudentList", page);
        }
        public async Task<IActionResult> EditAdmin(string username)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var res = await client.GetAsync($"api/User/getByUserName/" + username);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            AccountAdminDTO AccountAdminDTO = JsonConvert.DeserializeObject<AccountAdminDTO>(content);

            return View(AccountAdminDTO);
        }
        public async Task<IActionResult> EditStudent(string username)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await client.GetAsync("api/Class");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassDTO>>(content);
            var classSelectList = new SelectList(ClassDTOs, "ClassId", "ClassName");
            ViewBag.ClassSelectList = classSelectList;

            var resu = await client.GetAsync($"api/User/getByUserNameStudent/" + username);
            var contentu = await resu.Content.ReadAsStringAsync();

            if (!resu.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            AccountStudentDTO AccountStudentDTO = JsonConvert.DeserializeObject<AccountStudentDTO>(contentu);

            return View(AccountStudentDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditStudent([Bind("Username,FullName,Email,PhoneNumber,Address,BirthDay,ClassId,ParentFullName")] AccountStudentDTO register)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            RegisterModel user = new RegisterModel
            {
                Username = register.Username,
                Email = register.Email,
                FullName = register.FullName,
                Address = register.Address,
                BirthDay = register.BirthDay,
                ParentFullName = register.ParentFullName,
                PhoneNumber = register.PhoneNumber,
                ClassId = register.ClassId,
            };
            var bodyu = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var responseu = await client.PostAsync($"api/Authentication/updateStudent", bodyu);

            if (responseu.IsSuccessStatusCode)
            {
                ViewBag.Message = "Update thành công!";
                return RedirectToAction(nameof(StudentList));
            }
            ViewBag.Message = "Update không thành công!";
            return View("EditStudent", register);
        }
        public async Task<IActionResult> Create()
        {

            AccountAdminDTO AccountAdminDTO = new AccountAdminDTO();

            return View(AccountAdminDTO);
        }
        public async Task<IActionResult> CreateStudent()
        {

            AccountStudentDTO AccountStudentDTO = new AccountStudentDTO();
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await client.GetAsync("api/Class");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassDTO>>(content);
            var classSelectList = new SelectList(ClassDTOs, "ClassId", "ClassName");
            ViewBag.ClassSelectList = classSelectList;
            return View(AccountStudentDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateStudent([Bind("Username,FullName,Email,PhoneNumber,Address,BirthDay,ClassId,ParentFullName")] AccountStudentDTO register)
        {
            var tokenBytes = HttpContext.Session.Get("Token");
            if (tokenBytes == null || tokenBytes.Length == 0)
            {
                return RedirectToAction("Index", "Authen");
            }
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var resus = await client.GetAsync($"api/User/getByUserName/" + register.Username);
            var contentus = await resus.Content.ReadAsStringAsync();

            if ((int)resus.StatusCode == 200)
            {
                ViewBag.Message = "Username đã tồn tại!";
                return View("CreateStudent", register);
            }

            var rese = await client.GetAsync($"api/User/getByEmail/" + register.Email);
            var contente = await rese.Content.ReadAsStringAsync();

            if ((int)rese.StatusCode == 200)
            {
                ViewBag.Message = "Email đã tồn tại!";
                return View("CreateStudent", register);
            }
            string initialPassword = register.Username + "@123";
            string capitalizedPassword = char.ToUpper(initialPassword[0]) + initialPassword.Substring(1);
            RegisterModel user = new RegisterModel
            {
                Username = register.Username,
                Email = register.Email,
                Password = capitalizedPassword,
                Status = true,
                FullName = register.FullName,
                Address = register.Address,
                BirthDay = register.BirthDay,
                ParentFullName = register.ParentFullName,
                ParentPhone = "",
                PhoneNumber = register.PhoneNumber,
                ClassId = register.ClassId,
            };

            var bodyu = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var responseu = await client.PostAsync($"api/Authentication/registerStudent", bodyu);

            if (responseu.IsSuccessStatusCode)
            {
                ViewBag.Message = "Tạo mới thành công!";
                return RedirectToAction(nameof(StudentList));
            }
            ViewBag.Message = "Tạo mới không thành công!";
            return View("CreateStudent", register);
        }
        [HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Username,FullName,Email,PhoneNumber,Address,BirthDay,EducationName")] AccountAdminDTO register)
        {
			var resus = await client.GetAsync($"api/User/getByUserName/" + register.Username);
			var contentus = await resus.Content.ReadAsStringAsync();

			if ((int)resus.StatusCode == 200)
			{
				ViewBag.Message = "Username đã tồn tại!";
				return View("Registrator", register);
			}

			var rese = await client.GetAsync($"api/User/getByEmail/" + register.Email);
			var contente = await rese.Content.ReadAsStringAsync();

			if ((int)rese.StatusCode == 200)
			{
				ViewBag.Message = "Email đã tồn tại!";
				return View("Registrator", register);
			}
			// create education
			EducationDTO educationDTO = new EducationDTO()
            {
                Id = 0,
                Name = register.EducationName
            };
            var body = new StringContent(JsonConvert.SerializeObject(educationDTO), Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"api/Education", body);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                educationDTO = JsonConvert.DeserializeObject<EducationDTO>(content);
                string initialPassword = register.Username + "@123";
                string capitalizedPassword = char.ToUpper(initialPassword[0]) + initialPassword.Substring(1);
                RegisterModel user = new RegisterModel
                {
                    Username = register.Username,
                    Email = register.Email,
                    Password = capitalizedPassword,
                    Status = true,
                    FullName = register.FullName,
                    Address = register.Address,
                    BirthDay = register.BirthDay,
                    ParentFullName = "",
                    ParentPhone = "",
                    PhoneNumber = register.PhoneNumber,
                    EducationId = educationDTO.Id
                };
                var bodyu = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var responseu = await client.PostAsync($"api/Authentication/register", bodyu);

                if (responseu.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(AdminList));
                }
            }
            ViewBag.Message = "Tạo mới không thành công!";
            return View("Create", register);
        }
    }
}
