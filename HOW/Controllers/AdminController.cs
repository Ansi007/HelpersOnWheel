using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Models.Interfaces;

namespace HOW.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IQuestionRepository _questionRepository;
        public AdminController(ILogger<AdminController> logger, IQuestionRepository e)
        {
            _logger = logger;
            _questionRepository = e;
        }
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
            _questionRepository.DeleteQuestion(q);
            return View("Panel");
        }
    }
}
