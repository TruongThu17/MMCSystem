using Microsoft.AspNetCore.Mvc;

namespace MMCClient.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
