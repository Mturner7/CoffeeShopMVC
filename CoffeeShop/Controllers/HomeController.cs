﻿using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
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
        public IActionResult Register()
        {
            return View("../CoffeeShop/Registration");
        }

        [HttpPost]
        public IActionResult FormResponse(CustomerModel customer)
        {
            if (!ModelState.IsValid)
            {
                return View("../CoffeeShop/Registration");
            }

            ViewData["FullName"] = customer.FullName;
            ViewData["Email"] = customer.Email;
            ViewData["Password"] = customer.Password;
            return View("../CoffeeShop/FormResponse");
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