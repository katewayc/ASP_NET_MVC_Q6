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
            RouteDataValues routeDataValues = new RouteDataValues();

            routeDataValues.RouteArea = filterContext.RouteData.DataTokens["area"] as string;
            routeDataValues.RouteController = filterContext.RouteData.Values["controller"] as string;
            routeDataValues.RouteAction = filterContext.RouteData.Values["action"] as string;
            routeDataValues.RoutePage = filterContext.RouteData.Values["page"] as string;
            routeDataValues.RouteId = filterContext.RouteData.Values["id"] as string;
            routeDataValues.RouteCategory = filterContext.RouteData.Values["category"] as string;

            filterContext.Controller.ViewData["RouteDataValues"] = routeDataValues;

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