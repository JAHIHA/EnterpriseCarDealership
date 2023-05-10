using EnterpriseCarDealership.service_repository_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using EnterpriseCarDealership.Models;
namespace EnterpriseCarDealership.Pages.CRUDBike
{
    public class IndexBikeModel : PageModel
    {
        private IBikeService _service;

        public IndexBikeModel(IBikeService bikeService)

        {
            _service = bikeService;
        }

        [BindProperty]
        public List<Bike> bikes { get; set; }
        public async void OnGet()
        {
            bikes = _service.GetBikeList();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.Deletebike(id);
            bikes = _service.GetBikeList();

        }

    }

}