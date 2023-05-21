using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCarBooking
{
    public class CarPaymentModel : PageModel
    {
       private ICarBookingService _service { get; set; }
        public CarPaymentModel(ICarBookingService service)
        {
            _service = service;
        }

        [BindProperty]
        public double TotalPrice { get; set; }
        [BindProperty]
        public CarBooking? carbooking { get; set; }

        public void OnGet(int id)
        {
          carbooking = _service.GetCarbookingById(id);
            
            
                TotalPrice = _service.CalculatePayment(carbooking.Id, carbooking.CarId);
            
        }
        public void OnPostBack()
        {
            RedirectToPage("IndexCarBooking");
        }
    }
}
