using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Product.Controllers
{
    public class MainController : Controller
    {
        // GET: Product/Main
        public ActionResult List(string category)
        {
            string controller = RouteData.Values["controller"] as string;
            string action = RouteData.Values["action"] as string;
            string area = RouteData.DataTokens["area"] as string;

            ViewBag.area = area;
            ViewBag.controller = controller;
            ViewBag.action = action;
            ViewBag.category = category;

            return View();
        }
    }
}