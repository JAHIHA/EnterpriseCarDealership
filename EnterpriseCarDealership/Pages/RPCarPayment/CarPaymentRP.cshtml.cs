using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.RPCarPayment
{
    public class CarPaymentRPModel : PageModel
    {
        private readonly ICarPyamentService _carPyamentService;

        public CarPaymentRPModel(ICarPyamentService carPyamentService)
        {
            _carPyamentService = carPyamentService;
        }
        [BindProperty]
        public 

            public void OnGet()
        {
        }
    }
}
