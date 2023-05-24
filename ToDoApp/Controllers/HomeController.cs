using System;
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
            return View(new StudentViewModel());
        }

        public ActionResult Save(FormViewModel model)
        {
            return View("Success");
        }

        public ActionResult SaveStudent(StudentViewModel model)
        {
            ModelState.Clear();
            model.Id = model.Id ?? Guid.NewGuid().ToString();

            return TryValidateModel(model) ? View("Success") : View("Student", model);
        }
    }
}