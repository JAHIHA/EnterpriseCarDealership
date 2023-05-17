using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDMedarbejder
{
    public class UpdateMedarbejderModel : PageModel
    {
        private readonly IMedarbejderService _medarbejderService;
        public UpdateMedarbejderModel(IMedarbejderService medarbejderService)
        {
            _medarbejderService = medarbejderService;
        }
        [BindProperty]
        public Medarbejder medarbejder { get; set; }
        [BindProperty]
        public Medarbejder existingmedarbejder { get; set; } 
        public async Task<IActionResult>OnPost(int id)
        {
            await _medarbejderService.Updatemedarbejder(id,medarbejder);
            return RedirectToPage("IndexMedarbejder");
        }
        public IActionResult OnGet(int id)
        {
            existingmedarbejder = _medarbejderService.GetmedarbejderById(id);
            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true )
            {
                return RedirectToPage("/Index");

            }

            return Page();
        }
    }
}
