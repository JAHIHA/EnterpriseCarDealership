using DocumentFormat.OpenXml.Spreadsheet;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDManager;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class ManagerService : IManagerService
    {
        private IManagerRepo _managerRepo;

        public ManagerService(IManagerRepo managerRepo)
        {
            _managerRepo = managerRepo;
        }

        public async Task AddManager(CreateManager manager)
        {
            Manager newManager = new Manager()
            {
              NextId=manager.NextId,
                Name=manager.Name,
                Password=manager.Password,
                IsMedarbejder=manager.IsMedarbejder,
                IsAdmin=manager.IsAdmin,
                Tlf=manager.Tlf


            };
            await _managerRepo.AddManager(newManager);
        }

        public async Task DeleteManager(int id)
        {
            await _managerRepo.DeleteManager(id);
        }

        public Manager GetManagerById(int id)
        {
            Manager manager = _managerRepo.GetManagerById(id);
            
            return manager;
        }

        public List<Manager> GetManagerList()
        {
            return _managerRepo.GetManagerList();
        }

        public async Task UpdateManager(Manager manager)
        {
            await _managerRepo.UpdateManager(manager);
            
        }
    }
}
