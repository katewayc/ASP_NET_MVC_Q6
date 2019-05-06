using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class ActualRouteActionFilterAttribute : ActionFilterAttribute
    {
        private HttpWriter output;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            SetOutputString(filterContext.RouteData);
        }


        private void SetOutputString(RouteData rd)
        {
            string result = "";

            result+= rd.DataTokens["area"] ?? "";

            foreach (String key in rd.Values.Keys)
            {
                result += key+": "+ rd.Values[key] + ", ";
            }

            result += @" </br> </br> </br> </br>";
            output.WriteLine(result);
        }
    }
}