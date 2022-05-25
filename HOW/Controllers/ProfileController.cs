using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Timeline()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
