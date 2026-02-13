using Carlnsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carlnsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TestDb()
        {
            try
            {
                using (var db = new Entities())
                {
                    // Just touching the model triggers the same failure scaffolding hits
                    var count = db.Insurees.Count();
                    return Content("DB OK. Insurees count = " + count);
                }
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
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
    }
}