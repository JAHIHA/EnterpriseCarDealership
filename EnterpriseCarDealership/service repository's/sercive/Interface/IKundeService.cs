using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IKundeService
    {
        public List<Kunde> GetKundeList();

        public void Addkunde(Kunde kunde); 
        

        public void Updatekunde(Kunde kunde); 
  
      
        public Kunde GetKundeById(int id);
   
        public void Deletekunde(int id);

        }
}
