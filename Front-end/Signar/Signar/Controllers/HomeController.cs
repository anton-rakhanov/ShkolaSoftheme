﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult DashBoard()
        {
            ViewBag.Message = "Test page";

            return View();
        }

        public ActionResult MyProfile()
        {
            ViewBag.Message = "My Profile";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "My Profile";

            return View();
        }
    }
}