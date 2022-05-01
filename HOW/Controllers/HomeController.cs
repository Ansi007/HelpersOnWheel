//using HOW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HOW.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}