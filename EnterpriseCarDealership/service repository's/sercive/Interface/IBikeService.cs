using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBikeService
        //KARZAN
    {
        public List<Bike> GetBikeList();

        public void Addbike(Bike bike);


        public void Updatebike(Bike bike);


        public Bike GetBikeById(int id);

        public Bike Deletebike(int id);

    }
}
