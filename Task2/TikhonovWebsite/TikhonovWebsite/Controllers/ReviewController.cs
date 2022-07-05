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
    public class ReviewController : Controller
    {

        public List<Review> Reviews()
        {
            var db = new ElectronicsStoreContext();
            return db.Review.OrderByDescending(x => x.Id).ToList();            
        }


        public void AddReview(string review)
        {
            var db = new ElectronicsStoreContext();
            var count = db.Review.Count();
            db.Review.Add(new Review {Id = count+1, Body = review });
            db.SaveChanges();
        }
    }
}
