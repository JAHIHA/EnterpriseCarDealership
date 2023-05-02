using EnterpriseCarDealership.Models;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IKundeService
    {
     //KARZAN
        public List<Kunde> GetKundeList();

        public Task Addkunde(Kunde kunde);


        public Task Updatekunde(Kunde kunde);


        public Kunde GetKundeById(int id);

        public Task Deletekunde(int id);
    }
}
