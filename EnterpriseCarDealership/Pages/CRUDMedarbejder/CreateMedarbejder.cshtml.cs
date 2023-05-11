using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseCarDealership.Pages.CRUDMedarbejder
{
    public class CreateMedarbejderModel : PageModel
    {
        private readonly IMedarbejderService _service;

        public CreateMedarbejderModel(IMedarbejderService service)
        {
            _service = service;
        }
        [BindProperty]
        public CreateMedarbejder createMedarbejder { get; set;}

        public async Task OnPost()
        {
            await _service.Addmedarbejder(createMedarbejder);
        }
     
    }
    public class CreateMedarbejder
    {
        [Required]
        public int NextId { get; set; }

        [Required]
        public  string name { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public bool isMedarbejder { get; set; }
        [Required]
        public bool isAdmin { get; set; }
        [Required]
        public string tlf { get; set; }
        [Required]
        public string adress { get; set; }
        [Required]
        public int managerId { get; set; }

    }
}
