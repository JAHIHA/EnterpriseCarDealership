using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDBikeBooking
{
    public class UpdateBikeBookingModel : PageModel
    {
        private readonly IBikeBookingService _service;

        public UpdateBikeBookingModel(IBikeBookingService carBookingService)

        {
            _service = carBookingService;
        }

        [BindProperty]
        public BikeBooking bikeBooking { get; set; }
        [BindProperty]
        public BikeBooking existingBikeBooking { get; set; }
        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateBikebooking(bikeBooking);
            return RedirectToPage("IndexBikeBooking");
        }
        public void OnGet(int id)
        {
            existingBikeBooking = _service.GetBikebookingById(id);

        }
    }
}
