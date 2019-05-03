using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        [ActualRouteActionFilter]
        public ActionResult List(int? page)
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.DataTokens["area"] as string;

            ViewBag.area = area;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.page = page.ToString();

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