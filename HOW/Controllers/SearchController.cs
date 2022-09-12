using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Models.Interfaces;

namespace HOW.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly IQuestionRepository _questionRepository;
        public SearchController(ILogger<SearchController> logger, IQuestionRepository e)
        {
            _logger = logger;
            _questionRepository = e;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<Question> Find(string name, string title)
        {
            return _questionRepository.SearchQuesions(name, title);
        }
    }
}
