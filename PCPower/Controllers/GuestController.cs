using PCPower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCPower.Controllers
{
    public class GuestController : Controller
    {


        private PCPowerEntities db = new PCPowerEntities();

        //// GET: Guest
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult openParts()
        {
            return View(db.Parts.ToList());
        }
        public ActionResult openRegistrationForm()
        {
            return View("RegistrationForm");
        }
        public ActionResult submitData()
        {
            return View();
        }
        public ActionResult validateData()
        {
            return View();
        }
        public ActionResult openTrendingParts()
        {
            return View();
        }
        public ActionResult openSinglePart()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}