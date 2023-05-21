using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDBikeBooking
{
    public class BikePaymentModel : PageModel
    {
        private IBikeBookingService _service { get; set; }
        public BikePaymentModel(IBikeBookingService service)
        {
            _service = service;
        }

        [BindProperty]
        public double TotalPrice { get; set; }
        [BindProperty]
        public BikeBooking bikebooking { get; set; }

        public void OnGet(int id)
        {
            bikebooking = _service.GetBikebookingById(id);


            TotalPrice = _service.CalculatePayment(bikebooking.Id, bikebooking.BikeId);

        }
        public void OnPostBack()
        {
            RedirectToPage("IndexCarBooking");
        }
    }
}
