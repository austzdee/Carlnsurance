using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Carlnsurance.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            // Demo credentials (replace later if you want)
            if (username == "admin" && password == "Admin123!")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Admin", "Insuree");
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}