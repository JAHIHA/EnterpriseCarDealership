using EnterpriseCarDealership.Models;
using System.Text.Json;

namespace EnterpriseCarDealership.service_repository_s.Service.cookies
{
    public class SessionHelper
    {
        public static User GetUser(HttpContext context)
        {
            String? json = context.Session.GetString("User");
            if (json != null)
            {
                var user = JsonSerializer.Deserialize<User>(json);
                return user;
            }
            //User user = new User();
            //user.UserLoggetOut();

            return null;
        }
        public static void SetUser(User user, HttpContext context)
        {
            String json = JsonSerializer.Serialize(user);
            context.Session.SetString("User", json);
        }
    }
}
