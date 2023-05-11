using DocumentFormat.OpenXml.Spreadsheet;
using EnterpriseCarDealership.service_repository_s.Service.cookies;

namespace EnterpriseCarDealership.Models
{
    public class ValidateUser : IValidateUser
    {
        public bool Validate(User u)
        {
            List<User> users = new List<User>();

            foreach (var user in users)
            {
                if (u.Name == user.Name && user.Password== u.Password)
                {
                    Console.WriteLine(u.Password);
                    return true;
                }
            }
            return false;
        }
    }
}
