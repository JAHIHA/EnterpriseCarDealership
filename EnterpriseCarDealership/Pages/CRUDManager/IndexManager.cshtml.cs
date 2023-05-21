using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.sercive;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
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
        public IActionResult OnGet()
        {
           managers = _service.GetManagerList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true || us == null)
            {

                return RedirectToPage("/Index");
            }

            return Page();

        }

        public async Task OnPostDelete(int id)
        {
           await _service.DeleteManager(id);
            managers = _service.GetManagerList();

        }

        public void OnPostSort()
        {
            managers = _service.GetManagerList();
            
        }
        public void OnPostId()
        {
            managers = _service.GetManagerList();
            managers.OrderBy(h => h.NextId);


        }
        public void OnPostName()
        {
            managers = _service.GetManagerList();
            managers.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public void OnPosttlf()
        {
            managers = _service.GetManagerList();
            managers.Sort((x, y) => x.Tlf.CompareTo(y.Tlf));
        }
    }
}
