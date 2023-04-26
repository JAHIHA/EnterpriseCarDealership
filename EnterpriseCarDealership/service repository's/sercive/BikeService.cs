using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BikeService : IBikeService
    {
        //KARZAN
        public List<Bike> BikeList = new List<Bike>();
        public void Addbike(Bike bike)
        {
            BikeList.Add(bike); 
        }

        public void Deletebike(int id)
        {
            throw new NotImplementedException();
        }

        public Bike GetBikeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bike> GetBikeList()
        {
            throw new NotImplementedException();
        }

        public void Updatebike(Bike bike)
        {
            throw new NotImplementedException();
        }
    }
}
