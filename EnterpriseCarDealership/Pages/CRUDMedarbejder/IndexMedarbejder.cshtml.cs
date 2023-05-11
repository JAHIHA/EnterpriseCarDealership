using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
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

        public void OnGet()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
        }
        public async Task OnPostDelete(int id)
        {
            await _medarbejderService.Deletemedarbejder(id);
            medarbejders = _medarbejderService.GetmedarbejderList();
        }
    }
}
