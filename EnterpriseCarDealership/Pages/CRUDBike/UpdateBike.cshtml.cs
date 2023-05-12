using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDBike
{
    public class UpdateBikeModel : PageModel
    {

        private readonly IBikeService _service;

        public UpdateBikeModel(IBikeService bikeService)

        {
            _service = bikeService;
        }

        [BindProperty]
        public Bike bike { get; set; }

        //[BindProperty]
        //public Bike existingBike { get; set; }
        public async Task<IActionResult> OnPost()
        {
            await _service.Updatebike(bike);
            return RedirectToPage("IndexBike");
        }
        public IActionResult OnGet(int id)
        {
            bike = _service.GetBikeById(id);
            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("./Index");

            }

            return Page();

        }
       
    }
}
