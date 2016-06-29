using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsignarBusinessLayer;

namespace Signar.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Projects()
        {
            var test = new TestRoute();
            test.ChectRouteFromViewToDAL();
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            return View();
        }
    }
}