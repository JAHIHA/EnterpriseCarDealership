using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDCar.Filters
{
    public class FilterSunroof:ICarFilter
    {
        private ICarFilter _carFilter;
        UdenFilter uden= new UdenFilter();
        public List<Car> Filter()
        {
            uden.Filter().Where((S) => S.Sunroof);
            return uden.Filter();
        }
        public FilterSunroof(ICarFilter carFilter)
        {
            _carFilter = carFilter;
        }
    }
}
