using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnterpriseCarDealership.Models;
using System.ComponentModel.DataAnnotations;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

namespace EnterpriseCarDealership.Pages.CRUDBooking
{
    public class CreateCarBookingModel : PageModel
    {
        private readonly ICarBookingService _addservice;

        public CreateCarBookingModel(ICarBookingService carbookingService)
            
        {
            _addservice = carbookingService;
        }

        [BindProperty]
        public CreateCarBooking CreateCar { get; set; }

        public async Task OnPost()
        {
            await _addservice.AddCarbooking(CreateCar);
        }
    }

    
    public class CreateCarBooking
    {
        

        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int KundeId { get; set; }

        [Required]
        public int CarId { get; set; }

       

     

    }
}


