using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IBookingService
    {
        public List<Booking> GetbookingList();

        public void Addbooking(Booking booking);


        public void Updatebooking(Booking booking);


        public Booking GetbookingById(int id);

        public void Deletebooking(int id);


    }
}
