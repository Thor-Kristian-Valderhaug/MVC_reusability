using System.Web.Mvc;

namespace MVC_reusability.Areas.Innbo
{
    public class InnboAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Innbo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Innbo_default",
                "Innbo/{controller}/{action}/{id}",
                new { controller = "Account", action = "Index", id = UrlParameter.Optional },
                new[] {"MVC_reusability.Areas.Innbo.Controllers"}
            );
        }
    }
}
