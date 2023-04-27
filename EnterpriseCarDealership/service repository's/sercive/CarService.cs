using DocumentFormat.OpenXml.Math;
using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class CarService :ICarService
    {
        public List<Car> CarList = new List<Car>();

        public void Addcar(Car car)
        {
            CarList.Add(car);
        }

        public void Deletecar(int id)
        {
            Car car = GetCarById(id);
            CarList.Remove(car); ;
        }

        public Car GetCarById(int id)
        {
            return CarList.FirstOrDefault(x => x.Id == id);
        }

        public List<Car> GetCarList()
        {
            return CarList;
        }

        public void Updatecar(Car car)
        {
            var newcar = GetCarById(car.Id);
            if (newcar != null)
            {
                newcar.Id = car.Id;
                newcar.Brand = car.Brand;
                newcar.Type = car.Type;
                newcar.PrisPrDag = car.PrisPrDag;
                newcar.Year = car.Year;
                newcar.Km = car.Km;
                newcar.AC = car.AC;
                newcar.Sunroof = car.Sunroof;
                newcar.Screen = car.Screen;
                newcar.DVD = car.DVD;
                newcar.Camera=car.Camera;
                newcar.Sensor = car.Sensor;

            }
        }
    }
}
