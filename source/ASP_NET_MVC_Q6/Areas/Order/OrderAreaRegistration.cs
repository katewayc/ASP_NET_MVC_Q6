using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order
{
    public class OrderAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Order";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Order_detail",
                "OrderDetail/{id}",
                new { controller = "Default", action = "Detail", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Order_default",
                "Order/{controller}/{action}/{id}",
                new { action = "List", id = UrlParameter.Optional }
            );
        }
    }
}