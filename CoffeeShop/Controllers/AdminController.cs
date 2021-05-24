using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<Product> prods = ProductData.ReadAll();
            return View(prods);
        }

        [HttpGet]
        public IActionResult CreateForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            ProductData.Create(newProduct);

            ViewData["Message"] = "Congratulations, your product has been added to our database!";

            return RedirectToAction("ProductInfo", "Product", new { id = newProduct.productId });
        }

        [HttpGet]
        public IActionResult EditForm(int id)
        {
            Product outdatedProduct = ProductData.ReadOne(id);
            
            if (outdatedProduct == null)
            {
                return RedirectToAction("Index");
            }
            
            return View(outdatedProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct)
        {
            ProductData.Update(updatedProduct);

            return RedirectToAction("ProductInfo", "Product", new { id = updatedProduct.productId });
        }

        [HttpGet]
        public IActionResult DeleteForm(int id)
        {
            Product oldProduct = ProductData.ReadOne(id);

            if (oldProduct == null)
            {
                return RedirectToAction("Error", "Product");
            }

            return View(oldProduct);
        }


        [HttpPost]
        public IActionResult Delete(Product oldProduct)
        {
            ProductData.Delete(oldProduct);

            ViewData["Message"] = $"Salutations! Congratulations, '{oldProduct.productName}' has been deleted!";
            
            return RedirectToAction("Index");
        }
    }
}
