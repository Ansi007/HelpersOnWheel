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
            QuestionRepository questionRepository = new QuestionRepository();
            question.AuthorEmail = "annsshahbaz@gmail.com";
            questionRepository.AddQuestion(question);
            return View("Timeline");
        }
    }
}
