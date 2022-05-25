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
            if (SeekerRepositry.AddSeeker(seeker) > 0)
            {
                return RedirectToAction("SeekerLogin", "Login");
            }
            else
            {
                return View("Error","A person with same email already exists");
            }
        }
        [Route("/SignUp/HelperSignUp", Name = "signuphelper")]
        [HttpGet]
        public ViewResult HelperSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperSignUp(Helper helper)
        {
            if (HelperRepositry.AddHelper(helper) > 0)
            {
                return RedirectToAction("HelperLogin", "Login");
            }
            else
            {
                return View("Error", "A person with same email already exists");
            }
        }
    }
}
