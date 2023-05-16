using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDCar.Filters
{
    public interface ICarFilter
    {
        public List<Car> Filter(); 
    }
}
