using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace EnterpriseCarDealership.Pages.CRUDCar
{
    public class UpdateCarModel : PageModel
    {
        private readonly ICarService _carService;

        public UpdateCarModel(ICarService carService)
        {
            _carService = carService;   
        }
        [BindProperty]
        public Car car { get; set; }

        [BindProperty]
        public Car  existingCar { get; set; }

        public async Task<IActionResult>OnPost()
        {
            await _carService.Updatecar(car);
            return RedirectToPage("IndexCar");
        }
        public void OnGet(int id)
        {
            existingCar=_carService.GetCarById(id); 
        }
    }
}
