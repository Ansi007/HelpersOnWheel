using Microsoft.AspNetCore.Mvc;
using HOW.Models;

namespace HOW.ViewComponents
{
    public class Activity : ViewComponent
    {
        public IViewComponentResult Invoke(Question question)
        {
            ViewData["AuthorEmail"] = question.AuthorEmail;
            ViewData["Title"] = question.Title;
            ViewData["Description"] = question.Description;
            ViewData["Answers"] = question.Answers;
            return View();
        }
    }
}
