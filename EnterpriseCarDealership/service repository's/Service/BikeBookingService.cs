using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBikeBooking;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

namespace EnterpriseCarDealership.service_repository_s.Service
{
    public class BikeBookingService : IBikeBookingService
    {
         
        private readonly IBikeBookingRepo _BbookRep;
        private IBikeRepo _bikeRep;
        public BikeBookingService(IBikeBookingRepo BbookRep, IBikeRepo bikeRep)
        {
            _BbookRep = BbookRep;
            _bikeRep = bikeRep;
        }

        public async Task AddBikebooking(CreateBikeBooking Bbooking)
        {
            BikeBooking newBikeBooking = new BikeBooking()
            {
                StartTime = Bbooking.StartTime,
                EndTime = Bbooking.EndTime,
                KundeId = Bbooking.KundeId,
               
                BikeId = Bbooking.BikeId,


            };
            await _BbookRep.AddBikebooking(newBikeBooking);
        }


        public async Task DeleteBikebooking(int id)
        {
            await _BbookRep.DeleteBikebooking(id);
        }

        public BikeBooking? GetBikebookingById(int id)
        {
            BikeBooking Bbooking = _BbookRep.GetBikebookingById(id);
            if (Bbooking == null)
            {
                throw new KeyNotFoundException();
            }
            return Bbooking;
        }

        public List<BikeBooking> GetBikebookingList()
        {
            return _BbookRep.GetBikebookingList();
        }

        public bool IsOverlapping(BikeBooking Bbooking)
        {
            return GetBikebookingList()
                .Any(a => a.Id != Bbooking.Id && a.StartTime <= Bbooking.EndTime && Bbooking.StartTime <= a.EndTime && a.BikeId == Bbooking.BikeId);
        }

        public async Task UpdateBikebooking(BikeBooking Bbooking)
        {
            if (Bbooking != null)
            {
                await _BbookRep.UpdateBikebooking(Bbooking);
            }

        }
        public double CalculatePayment(int bookingId, int bikeId)
        {
            var bike = _bikeRep.GetBikeById(bikeId);
            var booking = _BbookRep.GetBikebookingById(bookingId);

            if (bike != null && booking != null)
            {
                return _BbookRep.CalculatePayment(bike, booking);
            }
            else
            {
                throw new Exception("Bike or booking not found.");
            }
        }
    }
}

