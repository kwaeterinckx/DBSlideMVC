using DBSlide_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DBSlide_MVC.Handlers
{
    public class ConnectedAuthorizeAttribute : CustomUserAuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationFilterContext context)
        {
            UserSession? user = GetUserSession(context);
            if (user is not null) return;
            context.Result = new RedirectToActionResult("Login", "Student", null);
        }
    }
}
