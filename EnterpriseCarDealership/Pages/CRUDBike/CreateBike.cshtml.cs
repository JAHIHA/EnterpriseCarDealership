using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBikeBooking;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseCarDealership.Pages.CRUDBike
{
    public class CreateBikeModel : PageModel
    {

        private readonly IBikeService _addservice;

        public CreateBikeModel(IBikeService bikeService)

        {
            _addservice = bikeService;
        }

        [BindProperty]
        public CreateBike createBike { get; set; }

        public async Task OnPost()
        {
            await _addservice.Addbike(createBike);
        }
    }

    public class CreateBike
    {

        [Required]
        public int NextId { get; set; } 

        [Required]
        public string Brand { get; set; }

        [Required]
        public MotorType Type { get; set; }

        [Required]
        public double PrisPrDag { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Km { get; set; }

        [Required]
        public bool Sidebike { get; set; }

        [Required]
        public bool LeatherSddle { get; set; }

        [Required]
        public bool ExtraStorage { get; set; }

    }
}