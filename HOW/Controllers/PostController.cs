using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
