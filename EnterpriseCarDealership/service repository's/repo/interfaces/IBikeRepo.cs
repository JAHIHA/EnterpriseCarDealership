using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.repo.interfaces
{
    public interface IBikeRepo
    {
        //KARZAN
        public List<Bike> GetBikeList();

        public Task Addbike(Bike bike);


        public Task Updatebike(Bike bike);


        public Bike GetBikeById(int id);

        public Task Deletebike(int id);
    }
}
