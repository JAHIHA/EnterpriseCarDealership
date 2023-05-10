using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDBikeBooking
{
    public class IndexBikeBookingModel : PageModel
    {
        private IBikeBookingService _service;

        public IndexBikeBookingModel(IBikeBookingService bikeBookingService)

        {
            _service = bikeBookingService;
        }

        [BindProperty]
        public List<BikeBooking> bikeBookings { get; set; }
        public void OnGet()
        {
            bikeBookings = _service.GetBikebookingList();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.DeleteBikebooking(id);
            bikeBookings = _service.GetBikebookingList();

        }
    }
}
