using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCarBooking
{
    public class UpdateCarBookingModel : PageModel
    {
        private readonly ICarBookingService _service;

        public UpdateCarBookingModel(ICarBookingService carBookingService)

        {
            _service = carBookingService;
        }

        [BindProperty]
        public CarBooking carBooking { get; set; }
        [BindProperty]
        public CarBooking existingCarBooking { get; set; }
        public async Task<IActionResult> OnPost(int id)
        {
            await _service.UpdateCarbooking(id, carBooking);
            return RedirectToPage("IndexCarBooking");
        }
        public void OnGet(int id)
        {
            existingCarBooking = _service.GetCarbookingById(id);

        }
    }
}
