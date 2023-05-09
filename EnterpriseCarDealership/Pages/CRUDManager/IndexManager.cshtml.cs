using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.sercive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDManager
{
    public class IndexManagerModel : PageModel
    {
        private IManagerService _service;

        public IndexManagerModel(IManagerService managerService)

        {
            _service = managerService;
        }

        [BindProperty]
        public List<Manager> managers { get; set; }
        public void OnGet()
        {
           managers = _service.GetManagerList();
        }

        public async Task OnPostDelete(int id)
        {
           await _service.DeleteManager(id);
            managers = _service.GetManagerList();

        }
    }
}
