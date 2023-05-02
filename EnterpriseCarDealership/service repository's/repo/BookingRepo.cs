using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class BookingRepo : IBookingRepo
    {
        private DealershipContext _bookdb = new DealershipContext();

        public async Task Addbooking(Booking booking)
        {
            _bookdb.Booking.Add(booking);
            await _bookdb.SaveChangesAsync();

        }

        public async Task Deletebooking(int id)
        {
            Booking? booking = GetbookingById(id);
            _bookdb.Booking.Remove(booking);
            await _bookdb.SaveChangesAsync();
        }

        public Booking? GetbookingById(int id)
        {
            Booking? booking = GetbookingList().FirstOrDefault(x => x.ID == id);
            return booking;
        }

        public List<Booking> GetbookingList()
        {
            return new List<Booking>(_bookdb.Booking);
        }

        public async Task Updatebooking(Booking booking)
        {
            Booking book = GetbookingById(booking.ID);


            booking.StartTime = book.StartTime;
            booking.EndTime = book.EndTime;
            booking.KundeId = book.KundeId;
            booking.CarId = book.CarId;
            _bookdb.Booking.Update(book);
            await _bookdb.SaveChangesAsync();

        }
    }
}

