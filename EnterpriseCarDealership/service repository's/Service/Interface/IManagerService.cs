using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.Manager;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IManagerService
    {
        public List<Manager> GetManagerList();

        public Task AddManager(CreateManager manager);


        public Task UpdateManager(Manager vmanager);


        public Manager GetManagerById(int id);

        public Task DeleteManager(int id);


    }
}
