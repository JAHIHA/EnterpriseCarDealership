using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
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

        public void OnGet()
        {
            kunder = _kundeService.GetKundeList();
        }
        public async Task OnPostDelete(int id)
        {
            await _kundeService.Deletekunde(id);
            kunder = _kundeService.GetKundeList();
        }
        
    }
}
