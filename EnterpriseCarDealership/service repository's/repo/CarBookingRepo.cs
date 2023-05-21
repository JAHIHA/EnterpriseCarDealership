using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class CarBookingRepo : ICarBookingRepo
    {
        private DealershipContext _Carbookdb = new DealershipContext();


        private readonly CarRepo _CarRepo = new CarRepo(); 

        public async Task Addcarbooking(CarBooking Carbooking)
        {
            Carbooking.StartTime = DateTime.Now.AddDays(1);
            Carbooking.EndTime = DateTime.Now.AddDays(2);
            _Carbookdb.CarBooking.Add(Carbooking);
            await _Carbookdb.SaveChangesAsync();

        }

        public async Task DeleteCarbooking(int id)
        {
            CarBooking? Carbooking = GetCarbookingById(id);
            _Carbookdb.CarBooking.Remove(Carbooking);
            await _Carbookdb.SaveChangesAsync();
        }

        public CarBooking GetCarbookingById(int id)
        {
           return _Carbookdb.CarBooking.FirstOrDefault(x => x.Id == id);
           
        }



        public async Task UpdateCarbooking(CarBooking Carbooking)
        {
            _Carbookdb.CarBooking.Update(Carbooking);
            await _Carbookdb.SaveChangesAsync();

        }

        public List<CarBooking> GetCarbookingList()
        {
            return new List<CarBooking>(_Carbookdb.CarBooking);
        }

        public async Task AddCarbooking(CarBooking carbooking)
        {
            _Carbookdb.CarBooking.Add(carbooking);
            await _Carbookdb.SaveChangesAsync();
        }

          
        public double CalculatePayment(Car car, CarBooking booking)
        {
            var res = GetCarbookingById(booking.Id);
            var result = _CarRepo.GetCarById(car.NextId);

            if (res != null && result != null)
            {
                TimeSpan duration = booking.EndTime - booking.StartTime;
                int numberOfDays = duration.Days + 1; // Include both the start and end dates

                double totalPayment = (numberOfDays * car.PrisPrDag);
                return totalPayment;
            }
            else
            {
                // Handle case where car or booking is not found
                throw new Exception("Car or booking not found.");
            }
        }
    }

}

