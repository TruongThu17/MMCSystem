﻿using Data.DTO;
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
    public class ClassController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public ClassController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        public async Task<IActionResult> IndexAsync(int? pageNumber)
        {
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await client.GetAsync("api/Class");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            PageSz<ClassDTO> page = new PageSz<ClassDTO>();
            page.PageSize = 10;
            List<ClassDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassDTO>>(content);

            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)ClassDTOs.Count / page.PageSize);
            List<ClassDTO> paginateds = ClassDTOs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginateds;  
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;

            return View(page);
        }
        public async Task<IActionResult> CreateAsync()
        {
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var res = await client.GetAsync("api/ClassType");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }
            List<ClassTypeDTO> ClassDTOs = JsonConvert.DeserializeObject<List<ClassTypeDTO>>(content);
            ClassDTO c = new ClassDTO();
            var classTypeSelectList = new SelectList(ClassDTOs, "ClassTypeId", "ClassTypeName");
            ViewBag.ClassTypeSelectList = classTypeSelectList;
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("ClassName,ClassTypeId")] ClassDTO classDTO)
        {

            var body = new StringContent(JsonConvert.SerializeObject(classDTO), Encoding.UTF8, "application/json");
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync($"api/Class", body);

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
