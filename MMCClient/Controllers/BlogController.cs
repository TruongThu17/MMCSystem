using Data.DTO;
using Data.Models;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;
using MMCClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

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
        public async Task<IActionResult> IndexAsync(int? pageNumber)
        {
            var resblog = await client.GetAsync("api/blog");
            var contentblog = await resblog.Content.ReadAsStringAsync();

            if (!resblog.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            PageSz<Blog> page = new PageSz<Blog>();
            page.PageSize = 8;
            List<Blog> blogs = JsonConvert.DeserializeObject<List<Blog>>(contentblog);

            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)blogs.Count / page.PageSize);
            List<Blog> paginatedBlogs = blogs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginatedBlogs;  // Change here: page.list to page.List
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            
            return View(page);
        }
        public async Task<IActionResult> BlogListSP(int? pageNumber, string? search)
        {

            PageSz<Blog> page = new PageSz<Blog>();
            List<Blog> blogs = new List<Blog>();
            if (search == null)
            {
                var resblog = await client.GetAsync("api/blog");
                var contentblog = await resblog.Content.ReadAsStringAsync();

                if (!resblog.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                blogs = JsonConvert.DeserializeObject<List<Blog>>(contentblog);
            }
            else
            {
                var resblog = await client.GetAsync("api/blog/search/"+search);
                var contentblog = await resblog.Content.ReadAsStringAsync();

                if (!resblog.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                blogs = JsonConvert.DeserializeObject<List<Blog>>(contentblog);
                page.searchString = search;
            }
            
            
            page.PageSize = 8;
            int validPageNumber = pageNumber.HasValue && pageNumber > 0 ? pageNumber.Value : 1;
            int totalPageCount = (int)Math.Ceiling((double)blogs.Count / page.PageSize);
            List<Blog> paginatedBlogs = blogs.Skip((validPageNumber - 1) * page.PageSize).Take(page.PageSize).ToList();

            page.list = paginatedBlogs;  
            page.PageNumber = validPageNumber;
            page.CountPage = totalPageCount;
            page.CountItem = blogs.Count;

            return View("BlogListSP",page);
        }

        public async Task<IActionResult> EditAsync(int id)
        {
            var res = await client.GetAsync($"api/blog/blogDTO/"+id);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            BlogDTO blog = JsonConvert.DeserializeObject<BlogDTO>(content);

            return View(blog);
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var res = await client.DeleteAsync($"api/blog/{id}");

            if (!res.IsSuccessStatusCode)
            {
                var errorContent = await res.Content.ReadAsStringAsync();
                _logger.LogError($"Failed to delete blog with ID {id}. Error: {errorContent}");
                return BadRequest("Failed to delete the blog entry.");
            }

            return RedirectToAction(nameof(BlogListSP));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("ID,Tilte, Description, Img, ImgFile, Date")] BlogDTO blogDTO)
        {
            if (blogDTO.ImgFile != null)
            {
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(blogDTO.ImgFile.FileName);
                try
                {
                    using (var stream = blogDTO.ImgFile.OpenReadStream())
                    {
                        await _firebaseStorage.Child("blog").Child(uniqueFileName).PutAsync(stream);
                    }

                    _logger.LogInformation($"Image '{uniqueFileName}' uploaded successfully.");
                    blogDTO.Img = $"https://firebasestorage.googleapis.com/v0/b/{_firebaseStorage.StorageBucket}/o/blog%2F{uniqueFileName}?alt=media";
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error uploading image: {ex.Message}");
                    return StatusCode(500, "Error uploading image to Firebase Storage.");
                }
            }

            Blog blog = new Blog()
            {
                ID = blogDTO.ID,
                Img = blogDTO.Img,
                Description = blogDTO.Description,
                Tilte = blogDTO.Tilte,
                Date = blogDTO.Date,
            };

            var body = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PutAsync($"api/Blog/{blogDTO.ID}", body);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(BlogListSP));
            }
            else
            {
                return StatusCode(500);
            }
        }
        public async Task<IActionResult> CreateAsync()
        {
           BlogDTO blog = new BlogDTO();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("ID,Tilte, Description, Img, ImgFile, Date")] BlogDTO blogDTO)
        {
            if (blogDTO.ImgFile != null)
            {
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(blogDTO.ImgFile.FileName);
                try
                {
                    using (var stream = blogDTO.ImgFile.OpenReadStream())
                    {
                        await _firebaseStorage.Child("blog").Child(uniqueFileName).PutAsync(stream);
                    }

                    _logger.LogInformation($"Image '{uniqueFileName}' uploaded successfully.");
                    blogDTO.Img = $"https://firebasestorage.googleapis.com/v0/b/{_firebaseStorage.StorageBucket}/o/blog%2F{uniqueFileName}?alt=media";
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error uploading image: {ex.Message}");
                    return StatusCode(500, "Error uploading image to Firebase Storage.");
                }
            }

            Blog blog = new Blog()
            {
                ID = 0,
                Img = blogDTO.Img,
                Description = blogDTO.Description,
                Tilte = blogDTO.Tilte,
                Date = DateTime.Now,
            };

            var body = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");
            var token = Encoding.UTF8.GetString(HttpContext.Session.Get("Token"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.PostAsync($"api/Blog", body);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(BlogListSP));
            }
            else
            {
                return StatusCode(500);
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            var res = await client.GetAsync($"api/blog/blogDTO/" + id);
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            BlogDTO blog = JsonConvert.DeserializeObject<BlogDTO>(content);
            return View(blog);
        }
    }
}
