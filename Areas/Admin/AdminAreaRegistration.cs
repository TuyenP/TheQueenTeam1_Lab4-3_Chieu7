using System.Web.Mvc;

namespace Lab4_3.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index",controller = "Cinemas", id = UrlParameter.Optional },
                 new[] { "Lab4_3.Areas.Admin.Controllers" }
            );
        }
    }
}