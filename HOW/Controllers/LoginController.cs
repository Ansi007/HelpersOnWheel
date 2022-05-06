using Microsoft.AspNetCore.Mvc;

namespace HOW.Controllers
{
    public class LoginController : Controller
    {
        public ViewResult HelperLogin()
        {
            return View();
        }

        public ViewResult SeekerLogin()
        {
            return View();
        }
    }
}
