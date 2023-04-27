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
            Bike bike = GetBikeById(id);
            BikeList.Remove(bike);
        }

        public Bike GetBikeById(int id)
        {
            return BikeList.FirstOrDefault(x => x.Id == id);
        }

        public List<Bike> GetBikeList()
        {
            return BikeList;
        }

        public void Updatebike(Bike bike)
        {
            var newbike = GetBikeById(bike.Id);
            if (newbike != null)
            {
                newbike.Id = bike.Id;
                newbike.Brand = bike.Brand;
                newbike.Type = bike.Type;
                newbike.PrisPrDag = bike.PrisPrDag;
                newbike.Year=bike.Year;
                newbike.Km=bike.Km;
                newbike.Sidebike = bike.Sidebike;
                newbike.LeatherSddle=bike.LeatherSddle;
                newbike.ExtraStorage = bike.ExtraStorage;


            }
        }
    }
}
