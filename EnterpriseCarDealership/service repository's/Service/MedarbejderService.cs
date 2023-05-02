using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class MedarbejderService: IMedarbejderService 

    {
        private IMedarbejderRepo _medarbejderRepo;
        public MedarbejderService(IMedarbejderRepo medarbejderRepo)
        {
            _medarbejderRepo = medarbejderRepo;
        }


        public async Task Addmedarbejder(Medarbejder medarbejder)
        {
           await _medarbejderRepo.Addmedarbejder(medarbejder);
            
        }

        public async Task Deletemedarbejder(int id)
        {

           await _medarbejderRepo.Deletemedarbejder(id); 
        }

        public Medarbejder GetmedarbejderById(int id)
        {
            Medarbejder medarbejder = _medarbejderRepo.GetmedarbejderById(id); 
            if (medarbejder ==null)
            {
                throw new Exception(); 
            }
            return medarbejder; 
        }

        public List<Medarbejder> GetmedarbejderList()
        {
            return _medarbejderRepo.GetmedarbejderList();
        }

        public async Task Updatemedarbejder(Medarbejder medarbejder)
        {
            
            if (medarbejder != null)
            {
                await _medarbejderRepo.Updatemedarbejder(medarbejder); 

            }

        }

        
    }


      
        }



      

  


        
    


