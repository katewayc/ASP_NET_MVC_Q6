using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket
{
    public class TicketAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Ticket";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Ticket_default",
                "Ticket/List",
                new { controller = "Main", action = "List" }
            );

            context.MapRoute(
               "Ticket_detail",
               "Ticket/Detail/{id}",
               new { controller = "Main", action = "Detail" , id = UrlParameter.Optional }
           );
        }
    }
}