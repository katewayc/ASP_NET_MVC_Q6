﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Default
        public ActionResult List(int? Id)
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.DataTokens["area"] as string;

            ViewBag.area = area;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.Id = Id.ToString();

            return View();
        }

        public ActionResult Detail(int? Id)
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.DataTokens["area"] as string;

            ViewBag.area = area;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.Id = Id.ToString();

            return View();
        }
    }
}