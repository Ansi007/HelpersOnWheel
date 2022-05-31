using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index(Question q)
        {
            return View(q);
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
