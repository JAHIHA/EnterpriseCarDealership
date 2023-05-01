using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBookingService
    {
        public List<Booking> GetbookingList();

        public Task Addbooking(Booking booking);


        public Task Updatebooking(Booking booking);


        public Booking GetbookingById(int id);

        public Task Deletebooking(int id);


    }
}
