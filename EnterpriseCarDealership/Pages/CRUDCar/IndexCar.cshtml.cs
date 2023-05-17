using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCar
{
    public class IndexCarModel : PageModel
    {
        private ICarService _carService;
        public IndexCarModel (ICarService carService)
        {
            _carService = carService;
        }
        [BindProperty]
        public List<Car> cars { get; set; } 

        public IActionResult OnGet()
        {
            cars=_carService.GetCarList();
         
                User us = SessionHelper.GetUser(HttpContext);
                if (us.IsAdmin != true && us.IsMedarbejder != true)
                {
                    return RedirectToPage("/Index");

                }

                return Page();
            
        }
        public async Task OnPostDelete(int id)
        {
            await _carService.Deletecar(id);
            cars = _carService.GetCarList(); 
        }

    }
}
