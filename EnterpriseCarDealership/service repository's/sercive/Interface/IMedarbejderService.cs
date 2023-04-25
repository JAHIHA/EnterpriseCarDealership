using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IMedarbejderService
    {
        public List<Medarbejder> GetmedarbejderList();

        public void Addmedarbejder(Medarbejder medarbejder);


        public void Updatemedarbejder(Medarbejder medarbejder);



        public Medarbejder GetmedarbejderById(int id);

        


        public void Deletemedarbejder(int id);
    }
}
