using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BookingService : IBookingService
    {
        private IBookingRepo _bookRep;
        public BookingService(IBookingRepo bookRep)
        {
            _bookRep = bookRep;
        }

        public Booking Addbooking(Booking booking)
        {
            return _bookRep.Addbooking(booking);
        }

        public async Task Deletebooking(int id)
        {
             await  _bookRep.Deletebooking(id);
        }

        public Booking? GetbookingById(int id)
        {
            Booking booking = _bookRep.GetbookingById(id);
            if (booking == null)
            {
                throw new KeyNotFoundException();
            }
            return booking;
        }

        public List<Booking> GetbookingList()
        {
            return _bookRep.GetbookingList();
        }

        public bool IsOverlapping(Booking booking)
        {
            return GetbookingList()
                .Any(a => a.ID != booking.ID && a.StartTime <= booking.EndTime && booking.StartTime <= a.EndTime && a.CarId == booking.CarId);
        }

        public Booking Updatebooking(Booking booking)
        {
            if (booking != null)
            {
                return _bookRep.Updatebooking(booking);
            }
            return booking;
        }
    }
}
