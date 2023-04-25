using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BookingService : IBookingService
    {
        public List<Booking> _bookings = new List<Booking>();

        public void Addbooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public void Deletebooking(int id)
        {
            Booking booking = GetbookingById(id);
            _bookings.Remove(booking);
        }

        public Booking? GetbookingById(int id)
        {
            foreach (Booking booking in _bookings)
            {
                if(booking.ID == id)
                {
                    return booking;
                }
            }
            return null;
        }

        public List<Booking> GetbookingList()
        {
            return new List<Booking>(_bookings);
        }

        public bool IsOverlapping(Booking booking)
        {
            return GetbookingList()
                .Any(a => a.ID != booking.ID && a.StartTime <= booking.EndTime && booking.StartTime <= a.EndTime && a.CarId == booking.CarId);
        }

        public void Updatebooking(Booking booking)
        {
            Booking book = GetbookingById(booking.ID);
            if (book != null)
            {
                booking.StartTime = book.StartTime;
                booking.EndTime = book.EndTime;
                booking.KundeId = book.KundeId;
                booking.CarId = book.CarId;
            }

        }
    }
}
