using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public CustomerModel Customer { get; set; }

        [HttpGet]
        public IActionResult Register()
        {
            return View("../CoffeeShop/Registration");
        }

        [HttpPost]
        public IActionResult FormResponse(CustomerModel customer)
        {
            return Content($"Welcome {customer.FullName}! \n\nYour Email: {customer.Email} \n\nYour Password: {customer.Password}");
        }
    
    }
}
