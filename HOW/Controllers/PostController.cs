using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Models.Interfaces;

namespace HOW.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private readonly IAnswerRepository _answerRepository;
        public PostController(ILogger<PostController> logger, IAnswerRepository e)
        {
            _logger = logger;
            _answerRepository = e;
        }
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
            _answerRepository.AddAnswer(email, title, ans);
            return View();
        }
    }
}
