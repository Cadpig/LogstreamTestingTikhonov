using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TikhonovWebsite.Models;
using TikhonovWebsite.DBContext;

namespace TikhonovWebsite.Controllers
{
    public class ElectronicsController : Controller
    {
        private readonly ElectronicsStoreContext db = new ElectronicsStoreContext();

        public ElectronicsController(ElectronicsStoreContext context)
        {
            db = context;
        }

        public IActionResult Show(string path)
        {
            ViewBag.Category = db.Category.OrderBy(x => x.Name).ToList();
            ViewBag.Review = db.Review.OrderBy(x => x.Id).ToList();
            ViewBag.ReviewMin = db.Review.OrderBy(x => x.Id).ToArray()[0];

            if (path == null)
            {
                // в корне сайта - показываю все товары
                ViewBag.Product = db.Product.OrderByDescending(x => x.CategoryId).ToList();
            }
            else
            {
                var PathId = db.Category.Where(x => x.Path == path).FirstOrDefault().Id;
                ViewBag.Product = db.Product.Where(x => x.CategoryId == PathId).OrderByDescending(x => x.Price).ToList();
            }

            return View();
        }

        public IActionResult Product(string path)
        {

            Product p = db.Product.FirstOrDefault(x => x.Path == path);
            if (p == null)
            {
                return NotFound();
            }
            ViewBag.Product = p;
            ViewBag.Category = db.Category.OrderBy(x => x.Name).ToList();
            return View();
        }

        public IActionResult Search(string text)
        {

            ViewBag.Category = db.Category.OrderBy(x => x.Name).ToList();

            var products = db.Product.Where(x => x.Title.IndexOf(text) >= 0 || x.Description.IndexOf(text) >= 0).ToList();

            ViewBag.Product = products;
            return View("Search");
        }

        public IActionResult AddReview(string review)
        {
            var count = db.Review.Count();
            db.Review.Add(new Review { Id = count + 1, Body = review });
            db.SaveChanges();
            return RedirectToAction("Show", "Electronics");
        }
    }
}
