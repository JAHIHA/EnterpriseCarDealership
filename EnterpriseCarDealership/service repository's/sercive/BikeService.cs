using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using System.Reflection.Metadata.Ecma335;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BikeService : IBikeService
    {
        //KARZAN

        private BikeDBContext dBContext = new BikeDBContext();

        public void Addbike(Bike bike)
        {
            dBContext.Bike.Add(bike);
            dBContext.SaveChanges();    
        }
       

        public Bike Deletebike(int id)
        {
            Bike bike = GetBikeById(id);
            dBContext.Bike.Remove(bike);    
            dBContext.SaveChanges();
            return bike; 
        }
        

        public Bike GetBikeById(int id)
        {
            return BikeList.FirstOrDefault(x => x.Id == id);
        }

        public List<Bike> GetBikeList()
        {
            return BikeList;
        }

        public Bike Updatebike(int id, Bike bike)
        {
            Bike newbike = GetBikeById((int)id);
            if (newbike != null)
            {
                
                newbike.Brand = bike.Brand;
                newbike.Type = bike.Type;
                newbike.PrisPrDag = bike.PrisPrDag;
                newbike.Year = bike.Year;
                newbike.Km = bike.Km;
                newbike.Sidebike = bike.Sidebike;
                newbike.LeatherSddle = bike.LeatherSddle;
                newbike.ExtraStorage = bike.ExtraStorage;


            }
            dBContext.Bike.Update(newbike);
            dBContext.SaveChanges();
            return newbike; 
        }
    }
}
