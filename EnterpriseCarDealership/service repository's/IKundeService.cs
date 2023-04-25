using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IKundeService
    {
        public List<Booking> GetKundeList();

        public void Addkunde(Booking kunde); 
        

        public void Updatekunde(Booking kunde); 
  
      
        public Booking GetKundeById(int id);
   
        public void Deletekunde(int id);



        }
}
