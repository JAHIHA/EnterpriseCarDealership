using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class KundeService : IKundeService
    {
        private List<Kunde> _kunder;

        public List<Kunde> GetKundeList()
        {
            return _kunder; 
        }


        public void Addkunde(Kunde kunde)
        {
            _kunder.Add(kunde);
            
        }


        public void Updatekunde(Kunde kunde)
        {
            var existingkunde = GetKundeById(kunde.Id);
            if (existingkunde != null)
            {
                existingkunde.Name = kunde.Name;
                existingkunde.Tlf = kunde.Tlf;
                existingkunde.Adress = kunde.Adress;
                existingkunde.Password = kunde.Password;


            }

        }
        


        public Kunde GetKundeById(int id)
        {
            return _kunder.FirstOrDefault(Kunde => Kunde.Id == id);
        }
        
        public void Deletekunde(int id)
        {
           Kunde kunde = GetKundeById(id);
            _kunder.Remove(kunde);
        }
    }
    }

