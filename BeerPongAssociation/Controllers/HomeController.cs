using BeerPongAssociation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerPongAssociation.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var db = ApplicationDbContext.Create();
            var news = db.SiteNews.OrderByDescending(n => n.Date).Take(4);

            return View(news.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}