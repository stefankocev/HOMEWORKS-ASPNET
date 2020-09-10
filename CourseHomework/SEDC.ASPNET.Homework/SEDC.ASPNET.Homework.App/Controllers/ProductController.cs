using Microsoft.AspNetCore.Mvc;
using SEDC.ASPNET.Homework.App.InMemoryDatabase;
using SEDC.ASPNET.Homework.App.Models.Domain;
using SEDC.ASPNET.Homework.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.ASPNET.Homework.App.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("products")]
        public IActionResult Index()
        {
            var products = Database.Products;
            var listOfProductsVM = new List<ProductVM>();

            foreach (var product in products)
            {
                var productVm = new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = product.Category,
                    Price = product.Price,
                    Description = product.Description
                };
                listOfProductsVM.Add(productVm);
            }
            return View("Index", listOfProductsVM);
        }

        [HttpGet("createProduct")]
        public IActionResult CreateProduct(string message)
        {
            ViewBag.Error = message;
            return View();
        }

        [HttpPost("createProduct")]
        public IActionResult CreateProduct(CreateProductVM product)
        {
            var products = Database.Products;
            var newProduct = new Product()
            {
                Id = Database.Products.Count + 1,
                Name = product.Name,
                Category = product.Category,
                Description = product.Description,
                Price = product.Price
            };

            if (newProduct.Name == null || newProduct.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "No product was added.Please try again." });
            }

           products.Add(newProduct);

            return RedirectToAction("Index", new { message = $"The product {newProduct.Name} was added on the list of products." });
        }
    }
}
