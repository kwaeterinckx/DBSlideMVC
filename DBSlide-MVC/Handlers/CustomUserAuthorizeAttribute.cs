using DBSlide_MVC.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace DBSlide_MVC.Handlers
{
    public abstract class CustomUserAuthorizeAttribute : CustomAuthorizeAttribute
    {
        protected UserSession? GetUserSession(AuthorizationFilterContext context)
        {
            return JsonSerializer.Deserialize<UserSession?>(
                context.HttpContext.Session.GetString("UserSession") ?? "null"
                );
        }
    }
}
