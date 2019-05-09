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
            RouteDataValues route = new RouteDataValues();
            route = ViewData["RouteDataValues"] as RouteDataValues;

            return View(route);
        }

        [ActualRoute]
        public ActionResult List()
        {
            RouteDataValues route = new RouteDataValues();
            route = ViewData["RouteDataValues"] as RouteDataValues;

            return View(route);
        }
    }
}