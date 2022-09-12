using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Models.Interfaces;

namespace HOW.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IQuestionRepository _questionRepository;
        public ProfileController(ILogger<ProfileController> logger, IQuestionRepository e)
        {
            _logger = logger;
            _questionRepository = e;
        }
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
            question.AuthorEmail = SessionManagement.currentUserEmail;
            _questionRepository.AddQuestion(question);
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
