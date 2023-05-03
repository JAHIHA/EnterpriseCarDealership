using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class BikeBookingRepo:IBikeBookingRepo
    {
        private DealershipContext _Bikebooking = new DealershipContext();

        

        public async Task DeleteBikebooking(int id)
        {
            BikeBooking? bikebooking = GetBikebookingById(id);
            _Bikebooking.BBooking.Remove(bikebooking);
            await _Bikebooking.SaveChangesAsync();
        }

        public BikeBooking GetBikebookingById(int id)
        {
            BikeBooking Bikebooking = GetBikebookingList().FirstOrDefault(x => x.ID == id);
            return Bikebooking;
        }



        public async Task UpdateBikebooking(BikeBooking Bikebooking)
        {
            BikeBooking book = GetBikebookingById(Bikebooking.ID);


            Bikebooking.StartTime = book.StartTime;
            Bikebooking.EndTime = book.EndTime;
            Bikebooking.KundeId = book.KundeId;
            Bikebooking.BikeId = book.BikeId;
            Bikebooking.PaymentId = book.PaymentId;
            _Bikebooking.BBooking.Update(book);
            await _Bikebooking.SaveChangesAsync();

        }

        public List<BikeBooking> GetBikebookingList()
        {
            return new List<BikeBooking>(_Bikebooking.BBooking);
        }

        public async Task AddBikebooking(BikeBooking Bikebooking)
        {
            _Bikebooking.BBooking.Add(Bikebooking);
            await _Bikebooking.SaveChangesAsync();

        }

 
    
}
}
