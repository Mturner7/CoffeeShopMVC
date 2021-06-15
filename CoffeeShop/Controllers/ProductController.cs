using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            List<Product> prods = ProductData.ReadAll();
            return View(prods);
        }

        [HttpGet]
        public IActionResult ProductInfo(int id)
        {
            Product selectedProduct = ProductData.ReadOne(id);

            if (selectedProduct != null)
            {
                return View(selectedProduct);
            }

            return RedirectToAction("Error");
        }

        public IActionResult Error()
        {
            return Content("The page you are looking for could not be found.");
        }
    }
}
