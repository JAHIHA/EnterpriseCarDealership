using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseCarDealership.Pages.CRUDBikeBooking
{
    public class CreateBikeBookingModel : PageModel
    {
        private readonly IBikeBookingService _addservice;

        public CreateBikeBookingModel(IBikeBookingService bikebookingService)

        {
            _addservice = bikebookingService;
        }

        [BindProperty]
        public CreateBikeBooking CreateBike {get; set; }


        public async Task<IActionResult> OnPost()
        {
            await _addservice.AddBikebooking(CreateBike);
            return RedirectToPage("IndexBikeBooking");
        }
    }
    }


    public class CreateBikeBooking
    {


        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int KundeId { get; set; }

        [Required]
        public int BikeId { get; set; }

    }
}

