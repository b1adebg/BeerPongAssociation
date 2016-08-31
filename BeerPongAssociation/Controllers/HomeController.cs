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
            var db = new ApplicationDbContext();
            var welcome = new WelcomeViewModel();
            welcome.LatestNews = db.SiteNews.OrderByDescending(n => n.Date).Take(4).ToList();
            welcome.FeaturedPlayer = db.Players.OrderByDescending(p => p.Popularity).FirstOrDefault();
            welcome.LastArticle = db.Articles.OrderByDescending(a => a.Date).FirstOrDefault();
            if (!db.Tournaments.Any(t => (t.StartDate < DateTime.Now && t.EndDate > DateTime.Now)))
            {
                welcome.FeaturedTournament = db.Tournaments.Where(t => t.EndDate < DateTime.Now).OrderByDescending(t => t.EndDate).FirstOrDefault();
            }
            else
            {
                welcome.FeaturedTournament = db.Tournaments.Where(t => (t.StartDate < DateTime.Now && t.EndDate > DateTime.Now)).FirstOrDefault();
            }

            return View(welcome);
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