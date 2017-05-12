using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class DemoMBController : Controller
    {
        // GET: DemoMB
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DemoMB()
        {
            DemoMBViewModel model = new DemoMBViewModel();

            model.Value_One = "Key";
            model.Value_Two = "Hidden";

            return View(model);
        }

        [HttpPost]
        public ActionResult DemoMB(DemoMBViewModel model)
        {

            return View(model);
        }
    }
}