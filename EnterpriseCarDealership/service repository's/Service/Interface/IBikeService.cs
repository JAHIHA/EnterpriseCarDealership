using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBikeService
        //KARZAN
    {
        public List<Bike> GetBikeList();

        public Task Addbike(Bike bike);


        public Task Updatebike(Bike bike);


        public Bike GetBikeById(int id);

        public Task Deletebike(int id);

    }
}
