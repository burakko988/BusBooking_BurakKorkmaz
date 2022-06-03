using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace BiletRezervasyon.WebUI.Helper
{
    public class UserFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string id = context.HttpContext.Session.GetString("user");

            if (id == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"action","Login" },
                    {"controller","Account" }
                });
            }

            base.OnActionExecuting(context);
        }
    }
}
