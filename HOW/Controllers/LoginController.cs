using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult HelperLogin()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SeekerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperLogin(Login l)
        {
            if (HelperRepositry.ValidateHelper(l))
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Error","Please Enter Valid Credentials");
        }

        [HttpPost]
        public IActionResult SeekerLogin(Login l)
        {
            if (SeekerRepositry.ValidateSeeker(l))
            {
                return RedirectToAction("Index","Home");
            }
            return View("Error", "Please Enter Valid Credentials");
        }
    }
}
