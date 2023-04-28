using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBookingService
    {
        public List<Booking> GetbookingList();

        public Booking Addbooking(Booking booking);


        public Booking Updatebooking(Booking booking);


        public Booking GetbookingById(int id);

        public Booking Deletebooking(int id);


    }
}
