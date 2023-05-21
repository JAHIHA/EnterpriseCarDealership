using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
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
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string tlf { get; set; }
        [BindProperty]
        public string Adress { get; set; }
        [BindProperty]
        public int ManagerId { get; set; }

        public IActionResult OnGet()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("/Index");

            }

            return Page();
        }


        public async Task OnPostDelete(int id)
        {
            await _medarbejderService.Deletemedarbejder(id);
            medarbejders = _medarbejderService.GetmedarbejderList();
        }

        public void OnPostId()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
            medarbejders.OrderBy(I => I.NextId);
        }

        public void OnPostName()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
            medarbejders.Sort((x, y) => x.Name.ToString().CompareTo(y.Name.ToString()));
        }
        public void OnPostTlf()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
            medarbejders.Sort((x, y) => x.Tlf.ToString().CompareTo(y.Tlf.ToString()));
        }
        public void OnPostAdress()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
            medarbejders.Sort((x, y) => x.Adress.ToString().CompareTo(y.Adress.ToString()));
        }
        public void OnPostManagerId()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
            medarbejders.OrderBy(M => M.ManagerId);
        }
        public void OnPostSort()
        {
            medarbejders = _medarbejderService.GetmedarbejderList();
        }
    }
    }
