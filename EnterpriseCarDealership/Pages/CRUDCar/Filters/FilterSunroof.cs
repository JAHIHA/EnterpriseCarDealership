using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDCar.Filters
{
    public class FilterSunroof:ICarFilter
    {
        private ICarFilter _carFilter;
        UdenFilter uden= new UdenFilter();
        public List<Car> Filter()
        {
            return null;
        }
    }
}
