using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductModel>
        {
                new ProductModel { ID = 1, Name = "Wooden Chair", Price = 50.00m},
                new ProductModel { ID = 2, Name = "Coffee Table", Price = 120.00m},
                new ProductModel { ID = 3, Name = "Sofa Set", Price = 350.00m},
                new ProductModel { ID = 4, Name = "Bookshelf", Price = 80.50m},
                new ProductModel { ID = 5, Name = "Lamp Stand", Price = 25.75m}
        };

            return View(products);
        }
    }
}
