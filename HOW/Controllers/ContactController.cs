using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
