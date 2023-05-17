using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.Service.cookies
{
    public interface IValidateUser
    {
        public User Validate(string navn, string password);
    }
}
