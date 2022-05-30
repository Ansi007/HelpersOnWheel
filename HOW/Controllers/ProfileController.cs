using Microsoft.AspNetCore.Mvc;
using HOW.Models;

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

        [HttpPost]
        public IActionResult Question(Question question)
        {
            question.AuthorEmail = "annsshahbaz@gmail.com";
            var context = new HelpersOnWheelContext();
            context.Questions.Add(question);
            context.SaveChanges();
            return View("Timeline");
        }
    }
}
