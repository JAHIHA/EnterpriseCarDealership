using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class BookingService : IBookingService
    {
        private BookingDBContext _bookdb = new BookingDBContext();

        public Booking Addbooking(Booking booking)
        {
            _bookdb.Booking.Add(booking);
            _bookdb.SaveChanges();
            return booking;
        }

        public Booking Deletebooking(int id)
        {
            Booking? booking = GetbookingById(id);
            _bookdb.Booking.Remove(booking);
            _bookdb.SaveChanges();
            return booking;
        }

        public Booking? GetbookingById(int id)
        {
            Booking? booking = GetbookingList().FirstOrDefault(x => x.ID == id);
            if (booking == null)
            {
                throw new KeyNotFoundException();
            }
            return booking;
        }

        public List<Booking> GetbookingList()
        {
            return new List<Booking>(_bookdb.Booking);
        }

        public bool IsOverlapping(Booking booking)
        {
            return GetbookingList()
                .Any(a => a.ID != booking.ID && a.StartTime <= booking.EndTime && booking.StartTime <= a.EndTime && a.CarId == booking.CarId);
        }

        public Booking Updatebooking(Booking booking)
        {
            Booking book = GetbookingById(booking.ID);
         
            if (book != null)
            {
                booking.StartTime = book.StartTime;
                booking.EndTime = book.EndTime;
                booking.KundeId = book.KundeId;
                booking.CarId = book.CarId;
            }
            _bookdb.Booking.Update(book);
            _bookdb.SaveChanges();
            return book;
        }
    }
}
