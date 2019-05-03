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
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            output = (HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            SetOutputString(filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        private void SetOutputString(RouteData rd)
        {
            var area = rd.DataTokens["area"];
            var controller = rd.Values["controller"];
            var action = rd.Values["action"];
            var OutputString = String.Format("Area: {0} </br> Controller: {1}</br> Action: {2} </br></br></br></br>", area, controller, action);
            output.WriteLine(OutputString.ToString());
        }
    }
}