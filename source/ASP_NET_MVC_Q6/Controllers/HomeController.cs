﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Welcome()
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;

            ViewBag.controller = controller;
            ViewBag.action = action;

            return View();
        }

        public ActionResult ContactMe()
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;

            ViewBag.controller = controller;
            ViewBag.action = action;

            return View();
        }
    }
}