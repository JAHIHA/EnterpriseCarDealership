using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDKunder
{
    public class IndexKundeModel : PageModel
    {

        private IKundeService _kundeService;
        public IndexKundeModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        [BindProperty]
        public List<Kunde> kunder { get; set; }

        public IActionResult OnGet()
        {
            kunder = _kundeService.GetKundeList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("./Index");

            }
            return Page();

        }
        public async Task OnPostDelete(int id)
        {
            await _kundeService.Deletekunde(id);
            kunder = _kundeService.GetKundeList();
        }
    }
}
