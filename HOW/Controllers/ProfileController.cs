using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Timeline()
        {
            if (SessionManagement.currentUserEmail == "") return RedirectToAction("Index", "Home");
            return View();
        }
        public IActionResult Edit()
        {
            if (SessionManagement.currentUserEmail == "") return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Question(Question question)
        {
            QuestionRepository questionRepository = new QuestionRepository();
            question.AuthorEmail = SessionManagement.currentUserEmail;
            questionRepository.AddQuestion(question);
            return View("Timeline");
        }
        public IActionResult Logout()
        {
            if (SessionManagement.currentUserEmail == "") return RedirectToAction("Index", "Home");
            SessionManagement session = new SessionManagement();
            session.Logout(HttpContext);
            return RedirectToAction("Index", "Home");
        }
    }
}
