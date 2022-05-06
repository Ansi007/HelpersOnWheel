using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
