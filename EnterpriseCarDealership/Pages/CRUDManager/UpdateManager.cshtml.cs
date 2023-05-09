using DocumentFormat.OpenXml.Office2010.Excel;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDManager
{
    public class UpdateManagerModel : PageModel
    {
        private readonly IManagerService _service;

        public UpdateManagerModel(IManagerService managerService)

        {
            _service = managerService;
        }

        [BindProperty]
        public Manager manager { get; set; }
        [BindProperty]
         public Manager existingManager { get; set; }
        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateManager(manager);
            return RedirectToPage("IndexManager"); 
        }
        public void OnGet(int id)
        {
           existingManager = _service.GetManagerById(id);

        }
    }
}
