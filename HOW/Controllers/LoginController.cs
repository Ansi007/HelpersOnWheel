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
            if (ModelState.IsValid)
            {
                if (HelperRepositry.ValidateHelper(l))
                {
                    return RedirectToAction("Index", "Home");
                }
                else return View("Error", "Please Enter Valid Credentials");
            }
            else return View();
        }

        [HttpPost]
        public IActionResult SeekerLogin(Login l)
        {
            if (ModelState.IsValid)
            {
                if (SeekerRepositry.ValidateSeeker(l))
                {
                    return RedirectToAction("Index", "Home");
                }
                return View("Error", "Please Enter Valid Credentials");
            }
            else return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
