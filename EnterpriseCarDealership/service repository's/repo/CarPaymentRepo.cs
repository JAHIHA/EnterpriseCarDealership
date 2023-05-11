using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class CarPaymentRepo : ICarPaymentRepo
    {
        private DealershipContext _db = new DealershipContext();
    
        public List<CarPayment> getCarPayments()
        {
            return new List<CarPayment>(_db.CarPayment);
        }
   
        
        public decimal CalculateCarPayment(Car PrisPrDag, int TotalDag, decimal TotalPayment)
        {

            decimal totalPayment =  

            return TotalPayment = PrisPrDag*TotalDag;
        }

       
    }
}
