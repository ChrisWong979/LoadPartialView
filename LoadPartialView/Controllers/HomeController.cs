using LoadPartialView.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LoadPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = new TestViewModel
            {
                BPCategories = new List<BPCategory>
                {
                    new BPCategory { Id = "1", Name = "Foo", Description = "F for Foo" },
                    new BPCategory { Id = "2", Name = "Bar", Description = "B for Bar" },
                    new BPCategory { Id = "3", Name = "Hello World", Description = "DONE" },
                }
            };
            return View(test);
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