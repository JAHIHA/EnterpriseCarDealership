using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IMedarbejderService
    {
        public List<Medarbejder> GetmedarbejderList();

        public Task Addmedarbejder(Medarbejder medarbejder);


        public Task Updatemedarbejder(Medarbejder medarbejder);



        public Medarbejder GetmedarbejderById(int id);

        


        public Task Deletemedarbejder(int id);
    }
}
