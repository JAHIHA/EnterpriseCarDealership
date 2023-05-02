using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public interface IMedarbejderRepo
    {
      
        
            public List<Medarbejder> GetmedarbejderList();

            public Task Addmedarbejder(Medarbejder medarbejder);


            public Task Updatemedarbejder(Medarbejder medarbejder);



            public Medarbejder GetmedarbejderById(int id);




            public Task Deletemedarbejder(int id);
        
    }
}
