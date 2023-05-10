using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.repo.interfaces
{
    public interface IBikeBookingRepo
    {
        public List<BikeBooking> GetBikebookingList();

        public Task AddBikebooking(BikeBooking booking);


        public Task UpdateBikebooking(int id,BikeBooking booking);


        public BikeBooking GetBikebookingById(int id);

        public Task DeleteBikebooking(int id);
    }
}
