using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Question> Find(string name, string title)
        {
            return new QuestionRepository().SearchQuesions(name, title);
        }
    }
}
