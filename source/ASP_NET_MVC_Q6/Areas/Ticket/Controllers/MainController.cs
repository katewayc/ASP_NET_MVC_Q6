using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket.Controllers
{
    public class MainController : Controller
    {
        [ActualRouteActionFilter]
        public ActionResult List()
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.DataTokens["area"] as string;

            ViewBag.area = area;
            ViewBag.controller = controller;
            ViewBag.action = action;

            return View();
        }

        [ActualRouteActionFilter]
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