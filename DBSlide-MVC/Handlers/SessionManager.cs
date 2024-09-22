using DBSlide_MVC.Models;
using System.Text.Json;

namespace DBSlide_MVC.Handlers
{
    public class SessionManager
    {
        private ISession _Session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _Session = httpContextAccessor.HttpContext.Session;
        }

        public UserSession? UserSession
        {
            get
            {
                return JsonSerializer.Deserialize<UserSession?>(
                    _Session.GetString(nameof(UserSession)) ?? "null"
                    );
            }
            set
            {
                if (value is null) _Session.Remove(nameof(UserSession));
                else
                    _Session.SetString(nameof(UserSession), JsonSerializer.Serialize(value));
            }
        }
    }
}
