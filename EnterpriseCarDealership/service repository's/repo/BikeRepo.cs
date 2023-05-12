using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class BikeRepo : IBikeRepo
    //KARZAN
    {
        private DealershipContext dBContext = new DealershipContext();
        

        public async Task Addbike(Bike bike)
        {
            dBContext.Bike.Add(bike);
            await dBContext.SaveChangesAsync();
        }

        public async Task Deletebike(int id)
        {
            Bike bike = GetBikeById(id);
            dBContext.Bike.Remove(bike);
            await dBContext.SaveChangesAsync();
    
        }

        public Bike GetBikeById(int id)
        {
            Bike bike = GetBikeList().FirstOrDefault(x => x.NextId == id);
            return bike;
        }

        public List<Bike> GetBikeList()
        {
            var bikes = dBContext.Bike.ToList();
            return bikes;
        }

        public async Task Updatebike(Bike bike)
        {
           //Bike newbike = GetBikeById(bike.NextId);
           //     newbike.NextId = bike.NextId;    
           //     newbike.Brand = bike.Brand;
           //     newbike.Type = bike.Type;
           //     newbike.PrisPrDag = bike.PrisPrDag;
           //     newbike.Year = bike.Year;
           //     newbike.Km = bike.Km;
           //     newbike.Sidebike = bike.Sidebike;
           //     newbike.LeatherSddle = bike.LeatherSddle;
           //     newbike.ExtraStorage = bike.ExtraStorage;


            
            dBContext.Bike.Update(bike);
            await dBContext.SaveChangesAsync();
        }
    }
}
