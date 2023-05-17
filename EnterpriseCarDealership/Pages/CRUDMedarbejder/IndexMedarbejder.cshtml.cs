using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDMedarbejder
{
    public class IndexMedarbejderModel : PageModel
    {
        private IMedarbejderService _medarbejderService;
        public IndexMedarbejderModel(IMedarbejderService medarbejderService)
        {
            _medarbejderService = medarbejderService;
        }
        [BindProperty]
        public List<Medarbejder> medarbejders { get; set; } 

        public IActionResult OnGet()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("/Index");

            }

            return Page();
        }


        public async Task OnPostDelete(int id)
        {
            await _medarbejderService.Deletemedarbejder(id);
            medarbejders = _medarbejderService.GetmedarbejderList();
        }
    }
}
