using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Models;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        [ActualRoute]
        public ActionResult List(int? page)
        {
            RouteDataValues route = new RouteDataValues();
            route = ViewData["RouteDataValues"] as RouteDataValues;

            return View(route);
        }

        [ActualRoute]
        public ActionResult Detail(int? Id)
        {
            RouteDataValues route = new RouteDataValues();
            route = ViewData["RouteDataValues"] as RouteDataValues;

            return View(route);
        }
    }
}