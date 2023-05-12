using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDKunder
{

    //KARZAN
    public class UpdateKundeModel : PageModel
    {

        private readonly IKundeService _kundeService;
        public UpdateKundeModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }
        [BindProperty]
        public Kunde kunde { get; set; }
        [BindProperty]
        public Kunde existingkunde { get; set; }
        public async Task<IActionResult> OnPost(int id)
        {
            await _kundeService.Updatekunde(id, kunde);
            return RedirectToPage("IndexKunde");
        }
        public void OnGet(int id)
        {
            existingkunde = _kundeService.GetKundeById(id);
        }

    }
}
