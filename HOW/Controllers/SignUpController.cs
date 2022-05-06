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
        public ViewResult SeekerSignUp(Seeker seeker)
        {
            return View();
        }

        [HttpGet]
        public ViewResult HelperSignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult HelperSignUp(Helper helper)
        {
            return View();
        }
    }
}
