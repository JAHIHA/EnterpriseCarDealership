using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IVehcileService
    {
        public List<Vehicle> GetKundeList();

        public void AddVehicle(Vehicle vehicle);


        public void UpdateVehicle(Vehicle vehicle);


        public Booking GetvehicleById(int id);

        public void Deletevehicle(int id);


    }
}
