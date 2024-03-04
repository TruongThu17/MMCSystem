using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;

namespace MMCClient.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseStorage _firebaseStorage;
        private readonly IWebHostEnvironment _env;

        private readonly HttpClient client;
        public BlogController(FirebaseStorage firebaseStorage, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _firebaseStorage = firebaseStorage;
            _logger = logger;
            _env = env;

            client = new() { BaseAddress = new Uri("http://localhost:5000") };
        }
        //public async Task<IActionResult> IndexAsync()
        //{
        //    var resblog = await client.GetAsync($"api/blog");
        //    var contentblog = await resblog.Content.ReadAsStringAsync();

        //    if (!resblog.IsSuccessStatusCode)
        //    {
        //        return BadRequest();
        //    }

        //    List<Data.Models.Blog> blogs = JsonConvert.DeserializeObject<List<Data.Models.Blog>>(contentblog);
        //    return View(blogs);
        //}
        public async Task<IActionResult> IndexAsync(int? pageNumber)
        {
            var resblog = await client.GetAsync("api/blog");
            var contentblog = await resblog.Content.ReadAsStringAsync();

            if (!resblog.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            PageSz<Data.Models.Blog> page = new PageSz<Data.Models.Blog>();
            page.PageSize = 8;
            List<Data.Models.Blog> blogs = JsonConvert.DeserializeObject<List<Data.Models.Blog>>(contentblog);
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)blogs.Count / page.PageSize);
            List<Data.Models.Blog> paginatedBlogs = blogs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginatedBlogs;  // Change here: page.list to page.List
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            
            return View(page);
        }



    }
}
