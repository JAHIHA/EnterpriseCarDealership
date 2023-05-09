using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDCar;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class CarService :ICarService
    {
        private ICarRepo _carRepo; 
     public CarService(ICarRepo carRepo)
        {
            _carRepo = carRepo; 
        }

        public async Task Addcar(CreateCar createCar)
        {
            Car car = new Car()
            {
                NextId = createCar.NextId,
                Brand = createCar.Brand,
                Type = createCar.type,
                PrisPrDag = createCar.PrisPrDag,
                Year = createCar.Year,
                Km = createCar.Km,
                AC = createCar.aC,
                Sunroof = createCar.sunroof,
                Screen = createCar.screen,
                DVD = createCar.dVD,
                Camera = createCar.camera,
                Sensor = createCar.sensor,

            };
            
            await _carRepo.Addcar(car); 
        }

        public async Task Deletecar(int id)
        {
            await _carRepo.Deletecar(id);   
        }

        public Car GetCarById(int id)
        {
            Car car = _carRepo.GetCarById(id); 
            return car; 
        }

        public List<Car> GetCarList()
        {
            return _carRepo.GetCarList();
        }

        public async Task Updatecar(int id, Car car)
        {
            await _carRepo.Updatecar(id, car); 
        }
        
    }
}
