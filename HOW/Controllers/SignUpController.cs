using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        [Route("/SignUp/SeekerSignUp", Name = "signupseeker")]
        public ViewResult SeekerSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SeekerSignUp(Seeker seeker)
        {
            if (ModelState.IsValid)
            {
                if (SeekerRepositry.AddSeeker(seeker) > 0)
                {
                    return RedirectToAction("SeekerLogin", "Login");
                }
                else
                {
                    return View("Error", "A person with same email already exists");
                }
            }
            else return View();
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
            if (ModelState.IsValid)
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
            else return View();
        }

        public string EmailAvailableSeeker(String email)
        {
            SeekerRepositry seekerRepositry = new SeekerRepositry();
            return seekerRepositry.ValidateEmail(email);
        }

        public string EmailAvailableHelper(String email)
        {
            HelperRepositry helperRepositry = new HelperRepositry();
            return helperRepositry.ValidateEmail(email);
        }
    }
}
