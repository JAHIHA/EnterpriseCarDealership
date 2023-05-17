using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDCar.Filters
{
    public class FilterSensor : ICarFilter
    {
        private ICarFilter _filter;
        UdenFilter uden = new UdenFilter();
        public List<Car> Filter()
        {
            uden.Filter().Where((n) => n.Sensor);
            return uden.Filter();
        }
        public FilterSensor(ICarFilter carFilter)
        {
            _filter = carFilter;    
                
        }
    }
}
