using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBike;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBikeService
        //KARZAN
    {
        public List<Bike> GetBikeList();

        public Task Addbike(CreateBike createbike);


        public Task Updatebike(Bike bike);


        public Bike GetBikeById(int id);

        public Task Deletebike(int id);

    }
}
