using Microsoft.AspNetCore.Mvc;

namespace MMCClient.Controllers
{
    public class AuthenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
