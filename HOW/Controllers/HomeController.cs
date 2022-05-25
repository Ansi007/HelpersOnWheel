using HOW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HOW.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //DataLists lists = new DataLists();
            //lists.helpers = HelperRepositry.GetHelpers();
            //lists.seekers = SeekerRepositry.GetSeekers();
            return View();
        }
    }
}