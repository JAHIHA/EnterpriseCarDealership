using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDMedarbejder;
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


        public async Task Addmedarbejder(CreateMedarbejder createMedarbejder)
        {
            Medarbejder newmedarbejder = new Medarbejder()
            {
                NextId = createMedarbejder.NextId,
                Name = createMedarbejder.name,
                Password = createMedarbejder.password,
                IsMedarbejder = createMedarbejder.isMedarbejder,
                IsAdmin = createMedarbejder.isAdmin,
                Tlf = createMedarbejder.tlf,
                Adress = createMedarbejder.adress,
                ManagerId = createMedarbejder.managerId

            };
           await _medarbejderRepo.Addmedarbejder(newmedarbejder);
            
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

        public async Task Updatemedarbejder(int id, Medarbejder medarbejder)
        {
            
            if (medarbejder != null)
            {
                await _medarbejderRepo.Updatemedarbejder(id,medarbejder); 

            }

        }

        
    }


      
        }



      

  


        
    


