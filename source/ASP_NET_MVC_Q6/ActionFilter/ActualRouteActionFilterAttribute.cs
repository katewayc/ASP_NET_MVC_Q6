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
            var id = rd.Values["id"];
            var page = rd.Values["page"];
            var category = rd.Values["category"];
            var OutputString = String.Format("Area: {0} </br> Controller: {1}</br> Action: {2} </br> Id: {3}</br> page: {4}</br> category: {5}</br></br></br></br>", area, controller, action,id,page, category);
            output.WriteLine(OutputString.ToString());
        }
    }
}