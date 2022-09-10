using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class PostController : Controller
    {
        static string email, title;
        public IActionResult Index(Question q)
        {
            email = q.AuthorEmail;
            title = q.Title;
            return View(q);
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Answer(string answer)
        {
            Answer ans = new Answer();
            ans.AuthorEmail = SessionManagement.currentUserEmail;
            ans.Title = "Answer";
            ans.Description = answer;
            AnswerRepository answerRepository = new AnswerRepository();
            answerRepository.AddAnswer(email, title, ans);
            return View();
        }
    }
}
