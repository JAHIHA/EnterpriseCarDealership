using DocumentFormat.OpenXml.ExtendedProperties;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCarBooking
{
    public class IndexCarBookingModel : PageModel
    {
        private ICarBookingService _service;

        public IndexCarBookingModel(ICarBookingService carBookingService)

        {
            _service = carBookingService;
        }

        [BindProperty]
        public List<CarBooking> carBookings { get; set; }
        public void OnGet()
        {
            carBookings = _service.GetCarbookingList();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.DeleteCarbooking(id);
            carBookings = _service.GetCarbookingList();

        }

        public void OnPostSort()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.Sort();
        }
        public void OnPostId()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.OrderBy(h => h.Id);


        }
        public void OnPostStartTime()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
        }
        public void OnPostEndTime()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.Sort((x, y) => x.EndTime.CompareTo(y.EndTime));
        }
        public void OnPostKundeId()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.Sort((x, y) => x.KundeId.CompareTo(y.KundeId));
        }
        public void OnPostCarId()
        {
            carBookings = _service.GetCarbookingList();
            carBookings.Sort((x, y) => x.CarId.CompareTo(y.CarId));
        }
    }
}
