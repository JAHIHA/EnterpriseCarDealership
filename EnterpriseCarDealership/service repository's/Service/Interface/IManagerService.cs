using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IManagerService
    {
        public List<Manager> GetManagerList();

        public Task AddManager(Manager manager);


        public Task UpdateManager(Manager vmanager);


        public Manager GetManagerById(int id);

        public Task DeleteManager(int id);


    }
}
