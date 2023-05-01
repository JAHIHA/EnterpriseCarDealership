using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class KundeService : IKundeService


    {

     private IKundeRepo _Kunderepo;

    public KundeService(IKundeRepo kundeRepo)
    {
        _Kunderepo = kundeRepo;
    }
    public async Task Addkunde(Kunde kunde)
        {
            await _Kunderepo.Addkunde(kunde);
        }

        public async Task Deletekunde(int id)
        {
            await _Kunderepo.Deletekunde(id);   
        }

        public Kunde GetKundeById(int id)
        {
            Kunde kunde = _Kunderepo.GetKundeById(id);
           
            return kunde;   
        }

        public List<Kunde> GetKundeList()
        {
            return _Kunderepo.GetKundeList();   
        }

        public async Task Updatekunde(Kunde kunde)
        {
            await _Kunderepo.Updatekunde(kunde);    
        }
    }
}

