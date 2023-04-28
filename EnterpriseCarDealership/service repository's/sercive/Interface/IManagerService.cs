using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IManagerService
    {
        public List<Manager> GetManagerList();

        public Manager AddManager(Manager manager);


        public Manager UpdateManager(Manager vmanager);


        public Manager GetManagerById(int id);

        public Manager DeleteManager(int id);


    }
}
