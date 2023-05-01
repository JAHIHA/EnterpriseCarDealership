using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class MedarbejderService: IMedarbejderService

    {
        private List<Medarbejder> _medarbejder;

        public void Addmedarbejder(Medarbejder medarbejder)
        {
            _medarbejder.Add(medarbejder);
        }

        public void Deletemedarbejder(int id)
        {
            Medarbejder medarbejder=GetmedarbejderById(id);
            _medarbejder.Remove(medarbejder);
        }

        public Medarbejder GetmedarbejderById(int id)
        {
            return _medarbejder.FirstOrDefault(Medarbejder => Medarbejder.Id == id);
        }

        public List<Medarbejder> GetmedarbejderList()
        {
            return _medarbejder.ToList();
        }

        public void Updatemedarbejder(Medarbejder medarbejder)
        {
            var existingmedarbejder = GetmedarbejderById(medarbejder.Id);
            if (existingmedarbejder != null)
            {
                existingmedarbejder.Name = medarbejder.Name;
                existingmedarbejder.Tlf = medarbejder.Tlf;
                existingmedarbejder.Adress = medarbejder.Adress;
                existingmedarbejder.Password = medarbejder.Password;
                existingmedarbejder.ManagerId = medarbejder.ManagerId;
                existingmedarbejder.IsAdmin = medarbejder.IsAdmin; 


            }

        }

        
    }


      
        }



      

  


        
    


