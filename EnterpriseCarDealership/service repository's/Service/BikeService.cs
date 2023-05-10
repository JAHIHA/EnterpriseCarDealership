using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBike;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BikeService : IBikeService
    {
        //KARZAN

        private IBikeRepo _Bikerepo;    

        public BikeService(IBikeRepo bikeRepo)
        {
            _Bikerepo = bikeRepo;   
        }

        public async Task Addbike(CreateBike createbike)
        {
            Bike bike = new Bike()
            {
                NextId=createbike.NextId,
                Brand = createbike.Brand,
                Type = createbike.Type,
                PrisPrDag = createbike.PrisPrDag,
                Year = createbike.Year,
                Km = createbike.Km,
                Sidebike = createbike.Sidebike,
                LeatherSddle = createbike.LeatherSddle,
                ExtraStorage = createbike.ExtraStorage,
            };


           await _Bikerepo.Addbike(bike);
        }
       

        public async Task Deletebike(int id)
        {
            await _Bikerepo.Deletebike(id);  
        }
        

        public Bike GetBikeById(int id)
        {
            Bike bike = _Bikerepo.GetBikeById(id);
            if (bike == null)
            {
                throw new KeyNotFoundException();   
            }
            return bike; 
        }

        public List<Bike> GetBikeList()
        {
            return _Bikerepo.GetBikeList();
        }


        public async Task Updatebike(Bike bike)
        {
 
            if (bike != null)
            {

                await _Bikerepo.Updatebike(bike);

            }

        }
    }
}
