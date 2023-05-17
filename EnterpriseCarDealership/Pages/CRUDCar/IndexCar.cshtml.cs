using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseCarDealership.Pages.CRUDCar
{
    public class IndexCarModel : PageModel
    {
        private ICarService _carService;
        public IndexCarModel (ICarService carService)
        {
            _carService = carService;
        }
        [BindProperty]
        public List<Car> cars { get; set; }
        [BindProperty]
        public double MaxPris { get; set; }
        [BindProperty]
        public double MinPris { get; set; }
        [BindProperty]
        public Boolean AC { get; set; }
        [BindProperty]
        public Boolean Sunroof { get; set; }
        [BindProperty]
        public Boolean Screen { get; set; }
        [BindProperty]
        public Boolean DVD { get; set; }
        [BindProperty]
        public Boolean Camera { get; set; }
        [BindProperty]
        public Boolean Sensor { get; set; }




        public IActionResult OnGet()
        {
            cars=_carService.GetCarList();
         
                User us = SessionHelper.GetUser(HttpContext);
                if (us.IsAdmin != true && us.IsMedarbejder != true)
                {
                    return RedirectToPage("./Index");

                }

                return Page();
            
        }
        public async Task OnPostDelete(int id)
        {
            await _carService.Deletecar(id);
            cars = _carService.GetCarList(); 
        }
        public void OnPostId()
        {
            cars = _carService.GetCarList();
            cars.OrderBy(I => I.NextId);
        }

        public void OnPostBrand()
        {
            cars = _carService.GetCarList();
            cars.Sort((x, y) => x.Brand.ToString().CompareTo(y.Brand.ToString()));

        }
        public void OnPostType()
        {
            cars = _carService.GetCarList();
            cars.Sort((x, y) => x.Type.ToString().CompareTo(y.Type.ToString()));  
        }
        public void OnPostPrisPrDag()
        {
            cars = _carService.GetCarList();
            cars.OrderBy(p => p.PrisPrDag);
        }
        public void OnPostYear()
        {
            cars = _carService.GetCarList();
            cars.OrderBy(Y => Y.Year);
        }
        public void OnPostKm()
        {
            cars = _carService.GetCarList();
            cars.OrderBy(k => k.Km);
        }
        public void OnPostAC()
        {
            cars = _carService.GetCarList();
            var Ac = cars.Select(A => A).Where(A => A.AC == true).ToList();
            cars = Ac; 
        }
        public void OnPostScreen()
        {
            cars = _carService.GetCarList();
            var Screen = cars.Select(S=> S).Where(S => S.Screen == true).ToList();
            cars = Screen;
        }
        public void OnPostDVD()
        {
            cars = _carService.GetCarList();
            var DVD = cars.Select(D => D).Where(D => D.DVD == true).ToList();
            cars = DVD;
        }
        public void OnPostCamera()
        {
            cars = _carService.GetCarList();
            var Camera = cars.Select(C => C).Where(C => C.Camera == true).ToList();
            cars = Camera;
        }
        public void OnPostSensor()
        {
            cars = _carService.GetCarList();
            var Sensor = cars.Select(s => s).Where(s =>s.Sensor == true).ToList();
            cars = Sensor;
        }
        public void OnPostMaxPris()
        {
            cars = _carService.GetCarList().Where((M) => M.PrisPrDag <= MaxPris).ToList(); 
            if (AC == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.AC).ToList();
            }
            if (Sunroof == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.Sunroof).ToList();
            }
            if (Screen == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.Screen).ToList();
            }
            if (DVD == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.DVD).ToList();
            }
            if (Camera == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.Camera).ToList();
            }
            if (Sensor == true)
            {
                cars = _carService.GetCarList().Where((M) => (M.PrisPrDag <= MaxPris) && M.Sensor).ToList();
            }
        }
        public void OnPostMinPris()
        {
            cars = _carService.GetCarList().Where((m) => m.PrisPrDag <= MinPris).ToList();
            if (AC == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.AC).ToList();
            }
            if (Sunroof == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.Sunroof).ToList();
            }
            if (Screen == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.Screen).ToList();
            }
            if (DVD == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.DVD).ToList();
            }
            if (Camera == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.Camera).ToList();
            }
            if (Sensor == true)
            {
                cars = _carService.GetCarList().Where((m) => (m.PrisPrDag <= MinPris) && m.Sensor).ToList();
            }

        }
    }
}
