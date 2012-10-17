using System.Web.Mvc;

namespace MVC_reusability.Areas.Motorvogn
{
    public class MotorvognAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Motorvogn";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Motorvogn_default",
                "Motorvogn/{controller}/{action}/{id}",
                new { Controller = "Account", action = "Index", id = UrlParameter.Optional },
                new[] { "MVC_reusability.Areas.Motorvogn.Controllers" }
            );
        }
    }
}
