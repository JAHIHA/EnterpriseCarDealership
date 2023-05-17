using DocumentFormat.OpenXml.Spreadsheet;
using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.Models
{
    public class ValidateUser : IValidateUser
    {
        public User? Validate(string navn, string password)
        {

            DealershipContext  _db =new DealershipContext();
            User user = null;
            if (navn != null && password != null)
            {
                user =  _db.Kunde.FirstOrDefault(u => u.Name == navn && u.Password == password);
                if (user == null)
                {
                    user = _db.Medarbejder.FirstOrDefault(u => u.Name == navn && u.Password == password);
                }
                if (user == null)
                {
                    user = _db.Manager.FirstOrDefault(u => u.Name == navn && u.Password == password);
                }
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            return null;
          
        }
    }
}
