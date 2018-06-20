using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic3.Models;

namespace Clinic3.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            // test line
            System.Web.HttpContext.Current.Session["loggedIn"] = false;

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
        public ActionResult Admin()
        {
      

            return View();
        }
        public ActionResult Doctor()
        {
            

            return View();
        }
        public ActionResult Patient()
        {         
            return View();
        }

        public patient GetPatientById(int id)
        {
            DataRepository repo = new DataRepository();
            return repo.GetPatientById(id);
        }
    }
}