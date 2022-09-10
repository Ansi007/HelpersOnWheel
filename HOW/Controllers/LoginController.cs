using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult HelperLogin()
        {
            ViewData["title"] = "Helper Login";
            ViewBag.Method = "/Login/HelperLogin";
            ViewBag.SignUpMethod = "signuphelper";
            return View("Index");
        }

        [HttpGet]
        public ViewResult SeekerLogin()
        {
            ViewData["title"] = "Seeker Login";
            ViewBag.Method = "/Login/SeekerLogin";
            ViewBag.SignUpMethod = "signupseeker";
            return View("Index");
        }

        [HttpPost]
        public IActionResult HelperLogin(Login l)
        {
            if (ModelState.IsValid)
            {
                if (HelperRepositry.ValidateHelper(l))
                {
                    SessionManagement.currentUserEmail = l.Email;
                    SessionManagement session = new SessionManagement();
                    session.Remove(HttpContext);
                    session.SetSession(HttpContext);
                    return RedirectToAction("Index", "Home");
                }
                else return View("Error", "Please Enter Valid Credentials");
            }
            ViewData["title"] = "Helper Login";
            ViewBag.Method = "/Login/HelperLogin";
            ViewBag.SignUpMethod = "signuphelper";
            return View("Index");
        }

        [HttpPost]
        public IActionResult SeekerLogin(Login l)
        {
            if (ModelState.IsValid)
            {
                if (SeekerRepositry.ValidateSeeker(l))
                {
                    SessionManagement.currentUserEmail = l.Email;
                    SessionManagement session = new SessionManagement();
                    session.Remove(HttpContext);
                    session.SetSession(HttpContext);
                    return RedirectToAction("Index", "Home");
                }
                return View("Error", "Please Enter Valid Credentials");
            }
            ViewData["title"] = "Seeker Login";
            ViewBag.Method = "/Login/SeekerLogin";
            ViewBag.SignUpMethod = "signupseeker";
            return View("Index");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
