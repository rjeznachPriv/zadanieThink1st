using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPageContent()
        {
            return PartialView("Content/ContentPartialView");
        }

        public ActionResult Form()
        {
            return View(new FormViewModel {ComboBoxItems = Helpers.DataHelper.GetYears(null) });
        }

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Save(FormViewModel model)
        {
            return View("Success");
        }
    }
}