using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
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
        
        public IActionResult OnGet(int id)
        {
            bikeBooking = _service.GetBikebookingById(id);
            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true && us.IsMedarbejder != true)
            {

                return RedirectToPage("./Index");
            }

            return Page();

        }
        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateBikebooking(bikeBooking);
            return RedirectToPage("IndexBikeBooking");
        }

    }
}
