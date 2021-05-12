using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoffeeShop.Controllers
{

    public class HomeController : Controller
    {
        private Regex phoneRgx = new Regex(@"^(\(\d{3}\)|\d{3})([\.\-\s])?(\d{3})([\.\-\s])?(\d{4})([\.\-\s])?$");
        private Regex emailrRgx = new Regex(@"^\w{5,30}\@\w{5,10}\.\w{1,3}$");
        private Regex passwordRgx = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{12,30}$");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserProfile(User user)
        {
            if (!passwordRgx.IsMatch(user.Password) || !phoneRgx.IsMatch(user.PhoneNumber)
               || !emailrRgx.IsMatch(user.Email) || user.FullName == null)
            {
                return RedirectToAction("Registration");
            }
            
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
