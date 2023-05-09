using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseCarDealership.Pages.CRUDManager
{
    public class CreateManagerModel : PageModel
    {
        private readonly IManagerService _addservice;

        public CreateManagerModel(IManagerService managerService)

        {
            _addservice = managerService;
        }

        [BindProperty]
        public CreateManager CreateManager { get; set; }


        public async Task OnPost()
        {
            await _addservice.AddManager(CreateManager);
        }
    }


    public class CreateManager
    {

        [Required]
        public int NextId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsMedarbejder { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        [Required]
        public string Tlf { get; set; }
    }
}

