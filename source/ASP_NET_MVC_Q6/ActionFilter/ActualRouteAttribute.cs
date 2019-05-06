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
        private HttpWriter output;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            SetOutputString(filterContext.RouteData);
        }


        private void SetOutputString(RouteData rd)
        {
            string result = "";

            foreach (String key in rd.DataTokens.Keys)
            {
                if (key == "area")
                {
                    result += key + ": " + rd.DataTokens[key]  +"<br/>";
                }
            }


            foreach (String key in rd.Values.Keys)
            {
                result += key + ": " + rd.Values[key] + "<br/>";
            }

            result += @"</br></br></br></br>";
            output.WriteLine(result);
        }
    }
}