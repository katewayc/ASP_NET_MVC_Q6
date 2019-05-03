using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Product
{
    public class ProductAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Product";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Product_default",
                "Product/{category}",
                new { controller = "Main", action = "List", category = UrlParameter.Optional }
            );
        }
    }
}