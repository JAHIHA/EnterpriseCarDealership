using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Math;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.sercive;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCarBooking
{
    public class IndexCarBookingModel : PageModel
    {
        private ICarBookingService _service;
        private ICarService _carservice;

        public IndexCarBookingModel(ICarBookingService carBookingService, ICarService carservice)

        {
            _service = carBookingService;
            _carservice = carservice;
        }

        [BindProperty]
        public List<CarBooking> carBookings { get; set; }
        [BindProperty]
        public double TotalPayment { get; set; }
        public IActionResult OnGet()
        {
            carBookings = _service.GetCarbookingList();
          

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true && us.IsMedarbejder != true)
            {

                return RedirectToPage("/Index");
            }
           
                return Page();
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
