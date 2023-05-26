using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.sercive;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseCarDealership.Pages.CRUDCar
{
    public class CreateCarModel : PageModel
    {
        private readonly ICarService _carService;
        public CreateCarModel(ICarService carService)
        {
            _carService = carService;
        }
        [BindProperty]
        public CreateCar createCar { get; set; }
        public async Task<IActionResult> OnPost()
        {
            await _carService.Addcar(createCar);
            return RedirectToPage("IndexCar");
        }
        public IActionResult OnGet()
        {
            
            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true && us.IsMedarbejder != true)
            {
                return RedirectToPage("/Index");

            }

            return Page();
        }
        
    }
    public class CreateCar
    {
        [Required]
        public int NextId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public MotorType Type { get;set; }
        [Required]
        public double PrisPrDag { get;set;}
        [Required]
        public int Year { get; set; }
        [Required]
        public int Km { get; set; }
        [Required]
        public bool AC { get; set; }
        [Required]
        public bool Sunroof { get; set; }
        [Required]
        public bool Screen { get; set; }
        [Required]
        public bool DVD { get; set; }
        [Required]
        public bool Camera { get; set; }
        [Required]
        public bool Sensor { get; set; }
       
         

    }
}
