using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ViewResult SeekerSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SeekerSignUp(Seeker seeker)
        {
            SeekerRepositry.AddSeeker(seeker);
            return RedirectToAction("SeekerLogin", "Login");
        }

        [HttpGet]
        public ViewResult HelperSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperSignUp(Helper helper)
        {
            HelperRepositry.AddHelper(helper);
            return RedirectToAction("HelperLogin", "Login");
        }
    }
}
