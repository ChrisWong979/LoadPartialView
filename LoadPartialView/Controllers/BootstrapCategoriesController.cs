using LoadPartialView.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LoadPartialView.Controllers
{
    public class BootstrapCategoriesController : Controller
    {
        // GET: BootstrapCategories
        public ActionResult Delete(List<BPCategory> bpCategories, string bpCategoryId)
        {
            var bpCategory = bpCategories.FirstOrDefault(id => id.Id == bpCategoryId);
            return View(bpCategory);
        }
    }
}
