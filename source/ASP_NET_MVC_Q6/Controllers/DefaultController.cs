using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.ActionFilter;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class DefaultController : Controller
    {
        [ActualRoute]
        public ActionResult Login()
        {
            RouteDataValues routeDataValues = new RouteDataValues();

            routeDataValues = ViewData["RouteDataValues"] as RouteDataValues;



            return View(routeDataValues);
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