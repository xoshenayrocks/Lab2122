using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab21__22.Models;
using Lab21__22.Services;

namespace Lab21__22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRegistrationUser _registrationUser;

        public HomeController(ILogger<HomeController> logger, IRegistrationUser registrationUser)
        {
            _logger = logger;
            _registrationUser = registrationUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            var user = new RegistrationViewModel();
            return View(user);
        }

        public IActionResult Summary(RegistrationViewModel user)
        {
            return View(user);
        }

      
        public IActionResult UserDetails(RegistrationViewModel user)
        {
            
            var userDetails = _registrationUser.Map(user);
            return View(userDetails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
