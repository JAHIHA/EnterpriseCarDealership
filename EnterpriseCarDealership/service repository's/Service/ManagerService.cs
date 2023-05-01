using DocumentFormat.OpenXml.Spreadsheet;
using EnterpriseCarDealership.Models;
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

        public async Task AddManager(Manager manager)
        {

            await _managerRepo.AddManager(manager);
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
