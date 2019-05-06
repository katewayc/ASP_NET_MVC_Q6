using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.ActionFilter;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class DefaultController : Controller
    {
        [ActualRoute]
        public ActionResult Login()
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;

            ViewBag.controller = controller;
            ViewBag.action = action;

            return View();
        }

        [ActualRoute]
        public ActionResult List()
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;

            ViewBag.controller = controller;
            ViewBag.action = action;

            return View();
        }
    }
}