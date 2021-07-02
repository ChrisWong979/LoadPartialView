using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadPartialView.Controllers
{
    public class BootstrapCategoriesController : Controller
    {
        // GET: BootstrapCategories
        public ActionResult Delete(string bpCategoriesId)
        {
            
            return View(bpCategoriesId);
        }
    }
}
