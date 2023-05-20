using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using EnterpriseCarDealership.Pages.CRUDBike.Filters;
using System;

namespace EnterpriseCarDealership.Pages.CRUDBike
{
    public class IndexBikeModel : PageModel
    {
        [BindProperty]
        public int MinPris { get; set; }

        [BindProperty]
        public int MaxPris { get; set; }

        [BindProperty]
        public bool Sidebike { get; set; }

        [BindProperty]
        public bool LeatherSddle { get; set; }

        [BindProperty]
        public bool ExtraStorage { get; set; }


        private readonly IbikeFilters _bikeFilters;
        private IBikeService _service;

        public IndexBikeModel(IBikeService bikeService)

        {
            _service = bikeService;
        }

        [BindProperty]
        public List<Bike> bikes { get; set; }


        public IActionResult OnGet()
        {
            bikes = _service.GetBikeList();

            User us = SessionHelper.GetUser(HttpContext);
            if (us.IsAdmin != true)
            {
                return RedirectToPage("/Index");

            }
            List<Bike> filteredBike = _bikeFilters.Filter();
            return Page();
        }

        public async Task OnPostDelete(int id)
        {
            await _service.Deletebike(id);
            bikes = _service.GetBikeList();

        }
        public void OnPostId()
        {
            bikes= _service.GetBikeList();
            bikes.OrderBy(b => b.NextId);
        }

        public void OnPostSort()
        {
            bikes = _service.GetBikeList();
            bikes.Sort();
        }

            public void OnPostFilterMax()
        {
            bikes = _service.GetBikeList().Where((b) => b.PrisPrDag <= MaxPris).ToList();



            if (Sidebike == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MaxPris) && b.Sidebike).ToList();

            }
            if (LeatherSddle == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MaxPris) && b.LeatherSddle).ToList();

            }
            if (ExtraStorage == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MaxPris) && b.ExtraStorage).ToList();

            }
            
        }
        public void OnPostFilterMin()
        {
            bikes = _service.GetBikeList().Where(s => s.PrisPrDag >= MinPris).ToList();

            if (Sidebike == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MinPris) && b.Sidebike).ToList();

            }
            if (LeatherSddle == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MinPris) && b.LeatherSddle).ToList();

            }
            if (ExtraStorage == true)
            {
                bikes = bikes.Where((b) => (b.PrisPrDag <= MinPris) && b.ExtraStorage).ToList();

            }
        }
    }
}