using HOW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HOW.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            SessionManagement session = new SessionManagement();
            session.GetSession(HttpContext);
            return View();
        }
    }
}