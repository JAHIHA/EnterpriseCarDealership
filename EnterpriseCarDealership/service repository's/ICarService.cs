using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface ICarService
        //KARZAN
    {
        public List<Car> GetCarList();

        public void Addcar(Car car);


        public void Updatecar(Car car);


        public Car GetCarById(int id);

        public void Deletecar(int id);

    }
}
