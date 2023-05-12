using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.Service.cookies;

namespace EnterpriseCarDealership.Pages.CRUDBike
{
    public class IndexBikeModel : PageModel
    {
        private IBikeService _service;

        public IndexBikeModel(IBikeService bikeService)

        {
            _service = bikeService;
        }

        [BindProperty]
        public List<Bike> bikes { get; set; }
        public IActionResult OnGet()
        {
            bikes = _service.GetBikeList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("./Index");

            }

            return Page();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.Deletebike(id);
            bikes = _service.GetBikeList();

        }

    }

}