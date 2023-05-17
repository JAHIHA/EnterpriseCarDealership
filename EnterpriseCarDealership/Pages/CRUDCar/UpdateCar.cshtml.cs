using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.service_repository_s.Service.cookies;

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
        
        public async Task<IActionResult>OnPost(int id)
        {
            await _carService.Updatecar( id, car);
            return RedirectToPage("IndexCar");
        }
        public IActionResult OnGet(int id)
        {
            
            existingCar=_carService.GetCarById(id);
        
            
                User us = SessionHelper.GetUser(HttpContext);
                if (us.IsAdmin != true && us.IsMedarbejder != true)
                {
                    return RedirectToPage("/Index");

                }

                return Page();
            
        }
    }
}
