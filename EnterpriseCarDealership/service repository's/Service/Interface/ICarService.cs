using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface ICarService
        //KARZAN
    {
        public List<Car> GetCarList();

        public Car Addcar(Car car);


        public Car Updatecar(Car car);


        public Car GetCarById(int id);

        public Car Deletecar(int id);

    }
}
