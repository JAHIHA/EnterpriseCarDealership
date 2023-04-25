using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class KundeService : IKundeService
    {
        private List<Booking> _kunder;

        public List<Booking> GetKundeList()
        {
            return _kunder; 
        }


        public void Addkunde(Booking kunde)
        {
            _kunder.Add(kunde); 
            
        }


        public void Updatekunde(Booking kunde)
        {
            var existingkunde = GetKundeById(kunde.Id);
            if (existingkunde != null)
            {
                existingkunde.Name = kunde.Name;
                existingkunde.Email = kunde.Email;
                existingkunde.Address = kunde.Address;
            }

        }
        


        public Booking GetKundeById(int id)
        {
            return _kunder.FirstOrDefault(Kunde => Kunde.Id == id);
        }
        
        public void Deletekunde(int id);
    }
}
