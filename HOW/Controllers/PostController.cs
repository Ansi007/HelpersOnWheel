using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var x = ViewBag;
            var y = ViewData;
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
