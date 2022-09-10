using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verify(string Username, string Password)
        {
            if(Username == "admin" && Password == "admin")
            {
                return View("Panel");
            }
            return View("Index");
        }

        public IActionResult Panel()
        {
            return View();
        }

        public IActionResult Remove(Question q)
        {
            QuestionRepository qr = new QuestionRepository();
            qr.DeleteQuestion(q);
            return View("Panel");
        }
    }
}
