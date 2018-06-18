using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinic2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "This is Admin Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Doctor()
        {
            ViewBag.Message = "Doctor Page";

            return View();
        }
        public ActionResult Patient()
        {
            ViewBag.Message = "Patient page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "login page";

            return View();
        }
    }
}