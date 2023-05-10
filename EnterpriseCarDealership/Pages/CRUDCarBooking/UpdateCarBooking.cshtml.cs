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
      
        public IActionResult OnGet(int id)
        {
            carBooking = _service.GetCarbookingById(id);
            return Page();

        }
        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateCarbooking(carBooking);
            return RedirectToPage("IndexCarBooking");
        }
    }
}
