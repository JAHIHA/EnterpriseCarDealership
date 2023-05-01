using EnterpriseCarDealership.Models;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public interface IKundeRepo
    {
        //KARZAN

        public Kunde ReadKunde(SqlDataReader reader);
        public List<Kunde> GetKundeList();

        public Task Addkunde(Kunde kunde);


        public Task Updatekunde(Kunde kunde);


        public Kunde GetKundeById(int id);

        public Task Deletekunde(int id);
    }
}
