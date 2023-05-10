using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBikeBooking;
using EnterpriseCarDealership.Pages.CRUDBooking;

namespace EnterpriseCarDealership.service_repository_s.Service.Interface
{
    public interface IBikeBookingService
    {
        
            public List<BikeBooking> GetBikebookingList();

            public Task AddBikebooking(CreateBikeBooking Bbooking);


            public Task UpdateBikebooking(int id, BikeBooking Bbooking);


            public BikeBooking GetBikebookingById(int id);

            public Task DeleteBikebooking(int id);


        
    }
}
