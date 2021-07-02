using LoadPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Test()
        {
            var test = new TestViewModel
            {
                BPCategories = new List<BPCategory>
                {
                    new BPCategory { Id = "1" },
                    new BPCategory { Id = "2" },
                    new BPCategory { Id = "3" },
                }
            };
            return View(test);
        }
    }
}