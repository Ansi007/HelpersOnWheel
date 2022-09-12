using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Models.Interfaces;

namespace HOW.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ILogger<SignUpController> _logger;
        private readonly IHelperRepository _helperRepository;
        private readonly ISeekerRepository _seekerRepository;


        public SignUpController(ILogger<SignUpController> logger, IHelperRepository e, ISeekerRepository seekerRepository)
        {
            _logger = logger;
            _helperRepository = e;
            _seekerRepository = seekerRepository;
        }

        [HttpGet]
        [Route("/SignUp/SeekerSignUp", Name = "signupseeker")]
        public ViewResult SeekerSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SeekerSignUp(Seeker seeker)
        {
            if (ModelState.IsValid)
            {
                if (_seekerRepository.AddSeeker(seeker) > 0)
                {
                    return RedirectToAction("SeekerLogin", "Login");
                }
                else
                {
                    return View("Error", "A person with same email already exists");
                }
            }
            else return View();
        }
        [Route("/SignUp/HelperSignUp", Name = "signuphelper")]
        [HttpGet]
        public ViewResult HelperSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperSignUp(Helper helper)
        {
            if (ModelState.IsValid)
            {
                if (_helperRepository.AddHelper(helper) > 0)
                {
                    return RedirectToAction("HelperLogin", "Login");
                }
                else
                {
                    return View("Error", "A person with same email already exists");
                }
            }
            else return View();
        }

        public string EmailAvailableSeeker(String email)
        {
            return _seekerRepository.ValidateEmail(email);
        }

        public string EmailAvailableHelper(String email)
        {
            return _helperRepository.ValidateEmail(email);
        }
    }
}
