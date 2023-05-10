
using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using EnterpriseCarDealership.Models;


namespace EnterpriseCarDealership.Pages.CRUDKunder
{
    public class CreateKundeModel : PageModel
    {
        private readonly IKundeService _addservice;

        public CreateKundeModel(IKundeService kundeService)

        {
            _addservice = kundeService;
        }

        [BindProperty]
        public CreateKunde createKunde { get; set; }


        public async Task OnPost()
        {
            await _addservice.Addkunde(createKunde);
        }
    }


    public class CreateKunde
    {

        [Required]
        public int NextId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public bool IsMedarbejder { get; set; }

        [Required]
        public bool isAdmin { get; set; }

        [Required]
        public string tlf { get; set; }

        [Required]
        public string adress { get; set; }

    }
}