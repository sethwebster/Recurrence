using System.Web.Mvc;

namespace Recurrence.Areas.apiv1
{
    public class apiv1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "apiv1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "apiv1_default",
                "apiv1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
