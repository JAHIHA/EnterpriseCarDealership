using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBikeBooking;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

namespace EnterpriseCarDealership.service_repository_s.Service
{
    public class BikeBookingService : IBikeBookingService
    {
         
        private readonly IBikeBookingRepo _BbookRep;
        public BikeBookingService(IBikeBookingRepo BbookRep)
        {
            _BbookRep = BbookRep;
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

        public async Task UpdateBikebooking(int id, BikeBooking Bbooking)
        {
            if (Bbooking != null)
            {
                await _BbookRep.UpdateBikebooking(id, Bbooking);
            }

        }
    }
}

