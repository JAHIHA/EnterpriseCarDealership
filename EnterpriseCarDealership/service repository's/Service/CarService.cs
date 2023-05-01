using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class CarService :ICarService
    {
      private DealershipContext _cardb = new DealershipContext();
        public List<Car> GetCarList()
        {
            return new List<Car>(_cardb.Car);
        }


        public Car GetCarById(int id)
        {

        }

       

        public Car Updatecar(Car car)
        {
            throw new NotImplementedException();
        }

        public Car Addcar(Car car)
        {
           _cardb.Car.Add(car);
            _cardb.Car.Sa
        }

        public Car Deletecar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
