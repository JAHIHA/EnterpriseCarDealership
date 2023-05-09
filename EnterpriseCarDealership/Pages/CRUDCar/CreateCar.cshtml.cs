using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
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

        public async Task OnPost()
        {
            await _carService.Addcar(createCar); 
        }
        
    }
    public class CreateCar
    {
        [Required]
        public int NextId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public MotorType type { get;set; }
        [Required]
        public double PrisPrDag { get;set;}
        [Required]
        public int Year { get; set; }
        [Required]
        public int Km { get; set; }
        [Required]
        public bool aC { get; set; }
        [Required]
        public bool sunroof { get; set; }
        [Required]
        public bool screen { get; set; }
        [Required]
        public bool dVD { get; set; }
        [Required]
        public bool camera { get; set; }
        [Required]
        public bool sensor { get; set; }
       
         

    }
}
