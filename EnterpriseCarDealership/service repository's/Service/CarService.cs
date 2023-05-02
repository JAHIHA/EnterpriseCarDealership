using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
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

        public async Task Addcar(Car car)
        {
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

        public async Task Updatecar(Car car)
        {
            await _carRepo.Updatecar(car); 
        }
        
    }
}
