using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic3.Models;

namespace Clinic3.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult getDoctorSchedule()
        {
            DataRepository r = new DataRepository();
            int id = 13;
            var schedule =r.getDoctorSchedule(id);
            return View(schedule);
        }
        public ActionResult getAllPatients()
        {
            DataRepository r = new DataRepository();
            var plist = r.getAllPatients();
            return View(plist);
        }

        public ActionResult getDoctorById()
        {
            DataRepository r = new DataRepository();
            int id = 13;
            var doctor = r.getDoctorById(id);
            return View(doctor);
        }

        public ActionResult AddAvailability()
        {
            return View();
        }
       
    }
}