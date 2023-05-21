using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class BikeBookingRepo : IBikeBookingRepo
    {
        private readonly DealershipContext _context = new DealershipContext();

        private readonly BikeRepo _BikeRepo = new BikeRepo();

        public async Task DeleteBikebooking(int id)
        {
            BikeBooking? bikebooking = GetBikebookingById(id);
            _context.BikeBooking.Remove(bikebooking);
            await _context.SaveChangesAsync();
        }

        public BikeBooking GetBikebookingById(int id)
        {
            BikeBooking Bikebooking = GetBikebookingList().FirstOrDefault(x => x.Id == id);
            return Bikebooking;
        }



        public async Task UpdateBikebooking( BikeBooking Bikebooking)
        {
            //BikeBooking book = GetBikebookingById(Bikebooking.Id);


            //Bikebooking.StartTime = book.StartTime;
            //Bikebooking.EndTime = book.EndTime;
            //Bikebooking.KundeId = book.KundeId;
            //Bikebooking.BikeId = book.BikeId;

            _context.BikeBooking.Update(Bikebooking);
            await _context.SaveChangesAsync();

        }

        public List<BikeBooking> GetBikebookingList()
        {
            return new List<BikeBooking>(_context.BikeBooking);
        }

        public async Task AddBikebooking(BikeBooking Bikebooking)
        {
            Bikebooking.StartTime = DateTime.Now.AddDays(1);
            Bikebooking.EndTime = DateTime.Now.AddDays(2);
            await _context.BikeBooking.AddAsync(Bikebooking);
            await _context.SaveChangesAsync();
        }

        public double CalculatePayment(Bike bike, BikeBooking booking)
        {
            var res = GetBikebookingById(booking.Id);
            var result = _BikeRepo.GetBikeById(bike.NextId);

            if (res != null && result != null)
            {
                TimeSpan duration = booking.EndTime - booking.StartTime;
                int numberOfDays = duration.Days + 1; // Include both the start and end dates

                double totalPayment = (numberOfDays * bike.PrisPrDag);
                return totalPayment;
            }
            else
            {
                // Handle case where car or booking is not found
                throw new Exception("Bike or booking not found.");
            }
        }

    }
}
