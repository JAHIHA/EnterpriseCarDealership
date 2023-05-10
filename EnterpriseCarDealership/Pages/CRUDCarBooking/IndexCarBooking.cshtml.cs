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
        public List<CarBooking> carBookings{ get; set; }
        public void OnGet()
        {
            carBookings = _service.GetCarbookingList();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.DeleteCarbooking(id);
            carBookings = _service.GetCarbookingList();

        }
    }
}
