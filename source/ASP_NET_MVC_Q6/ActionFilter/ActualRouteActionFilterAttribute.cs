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
            var area = rd.DataTokens["area"]??"";
            var controller = rd.Values["controller"] ?? "";
            var action = rd.Values["action"] ?? "";
            var id = rd.Values["id"] ?? "";
            var page = rd.Values["page"] ?? "";
            var category = rd.Values["category"] ?? "";

            string _outputString = "";
            if (!string.IsNullOrEmpty(area.ToString()))
            {
                _outputString += string.Format("Area: {0} </br> ", area);
            }
            if (!string.IsNullOrEmpty(controller.ToString()))
            {
                _outputString += string.Format("Controller: {0} </br> ", controller);
            }
            if (!string.IsNullOrEmpty(action.ToString()))
            {
                _outputString += string.Format("Action: {0} </br> ", action);
            }
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                _outputString += string.Format("Id: {0} </br> ", id);
            }
            if (!string.IsNullOrEmpty(page.ToString()))
            {
                _outputString += string.Format("page: {0} </br> ", page);
            }
            if (!string.IsNullOrEmpty(category.ToString()))
            {
                _outputString += string.Format("category: {0} </br> ", category);
            }

            _outputString += @" </br> </br> </br> </br>";
            output.WriteLine(_outputString);

            //var OutputString = string.Format("Area: {0} </br> Controller: {1}</br> Action: {2} </br> Id: {3}</br> page: {4}</br> category: {5}</br></br></br></br>", area, controller, action,id,page, category);
            //output.WriteLine(OutputString.ToString());
        }
    }
}