using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.Login
{
    public class LoginModel : PageModel
    {
        
        private IManagerService _services;
        private IValidateUser _validateService;

        public LoginModel(IManagerService services, IValidateUser valuser)
        {
            _services = services;
            _validateService = valuser;
        }


        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {

            User us = SessionHelper.GetUser(HttpContext);



        }

        public IActionResult OnPost()
        {
            User us = SessionHelper.GetUser(HttpContext);
            //User us = new User();


            if (Name is not null && Password is not null)
            {
                us.Name = Name;

                us.Password = Password;

                if (_validateService.Validate(us))
                {
                   
                    SessionHelper.SetUser(us, HttpContext);
                    return RedirectToPage("./Index");
                }

            }
            return Page();

        }
    }
}

