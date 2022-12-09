using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "The current team:";

            return View();
        }

        public ActionResult Copyright()
        {
            return View();
        }

        public ActionResult Store()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }
    }
}