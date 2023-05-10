using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBooking;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.sercive
{
    public class CarBookingService : ICarBookingService
    {
        private ICarBookingRepo _CbookRep;
        public CarBookingService(ICarBookingRepo CbookRep)
        {
            _CbookRep = CbookRep;
        }

        public async Task AddCarbooking(CreateCarBooking Cbooking)
        {
            CarBooking newCarBooking = new CarBooking()
            {
                
                StartTime = Cbooking.StartTime,
                EndTime = Cbooking.EndTime,
                KundeId = Cbooking.KundeId,
                CarId = Cbooking.CarId,
      
            };
            await _CbookRep.AddCarbooking(newCarBooking);
        }

        public async Task DeleteCarbooking(int id)
        {
            await _CbookRep.DeleteCarbooking(id);
        }

        public CarBooking? GetCarbookingById(int id)
        {
            CarBooking Cbooking = _CbookRep.GetCarbookingById(id);
            if (Cbooking == null)
            {
                throw new KeyNotFoundException();
            }
            return Cbooking;
        }

        public List<CarBooking> GetCarbookingList()
        {
            return _CbookRep.GetCarbookingList();
        }

        public bool IsOverlapping(CarBooking Cbooking)
        {
            return GetCarbookingList()
                .Any(a => a.Id != Cbooking.Id && a.StartTime <= Cbooking.EndTime && Cbooking.StartTime <= a.EndTime && a.CarId == Cbooking.CarId);
        }

        public async Task UpdateCarbooking(CarBooking Cbooking)
        {
            if (Cbooking != null)
            {
                await _CbookRep.UpdateCarbooking(Cbooking);
            }
           
        }
    }
}
