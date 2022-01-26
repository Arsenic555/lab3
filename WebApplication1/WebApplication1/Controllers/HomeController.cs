using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();
        public List<Product> catalog;
        private readonly ILogger<HomeController> _logger;
        public List<OrderItem> cart;

        public HomeController()
        {
            catalog = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Ъ",
                    Price = 100,
                    Ammount = 10,
                    Desc = "Большая буква \"Ъ\". Возможности использования просто огромны!",
                    Img = "/Img/1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Особая Шапка",
                    Price = 1000,
                    Ammount = 13,
                    Desc = "Интересная шапка не только согреет голову, но и скрасит любую зиму своей необычностью!",
                    Img = "/Img/ui_ph.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Деревянная статуя",
                    Price = 10,
                    Ammount = 1,
                    Desc = "Деревянная статуя ростом 2 метра. Идеально украсит любой интерьер!",
                    Img = "/Img/3.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Ь",
                    Price = 100,
                    Ammount = 10,
                    Desc = "Большая буква \"Ь\". Возможности использования просто огромны!",
                    Img = "/Img/2.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Маска карнавальная",
                    Price = 1050,
                    Ammount = 103,
                    Desc = "Оригинальная карнавальная маска из лучших материалов. Позволит стать душой любой вечеринки!",
                    Img = "/Img/4.jpg"
                }
            };
            cart = new List<OrderItem> { };
        }
        public IActionResult Index(int i)
        {
            ViewBag.Name = catalog[i].Name;//db.Products.Find(i).Name;
            ViewBag.Desc = catalog[i].Desc;//db.Products.Find(i).Desc;
            ViewBag.Img = catalog[i].Img;//db.Products.Find(i).Img;
            ViewBag.Ammount = catalog[i].Ammount;// db.Products.Find(i).Ammount;
            return View(db.Products);
        }

        public IActionResult DeleteItem(int i)
        {
            catalog.RemoveAt(i);
            return RedirectToAction("Manager");
        }

        [HttpPost]
        public IActionResult AddItemToCatalog(string name, string desc, int price, int ammount, int img)
        {

            return RedirectToAction("Manager");
        }

        [HttpPost]
        public IActionResult AddItemToCart()
        {

            return RedirectToAction("OrderDone");
        }

        public IActionResult OrderDone(int i)
        {
            ViewBag.ord_id = i;
            return View();
        }

        public IActionResult Manager()
        {
            return View(catalog);
        }

        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult NewProduct()
        {
            return View(db.Products);
        }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }
}
