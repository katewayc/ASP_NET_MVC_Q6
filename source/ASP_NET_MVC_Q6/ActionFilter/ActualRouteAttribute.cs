using ASP_NET_MVC_Q6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class ActualRouteAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RouteDataValues route = new RouteDataValues();

            route.Area = filterContext.RouteData.DataTokens["area"] as string;
            route.Controller = filterContext.RouteData.Values["controller"] as string;
            route.Action = filterContext.RouteData.Values["action"] as string;
            route.Page = filterContext.RouteData.Values["page"] as string;
            route.Id = filterContext.RouteData.Values["id"] as string;
            route.Category = filterContext.RouteData.Values["category"] as string;

            filterContext.Controller.ViewData["RouteDataValues"] = route;

            //SetOutputString(filterContext.RouteData);
        }


        private void SetOutputString(RouteData rd)
        { 
            string result = "";

            foreach (String key in rd.DataTokens.Keys)
            {
                if (key == "area")
                {
                    result += key + ": " + rd.DataTokens[key] + "<br/>";
                }
            }

            foreach (String key in rd.Values.Keys)
            {
                result += key + ": " + rd.Values[key] + "<br/>";
            }

            result += @"</br></br></br></br>";
        }
    }
}