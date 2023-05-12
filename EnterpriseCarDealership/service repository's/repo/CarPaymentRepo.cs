using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class CarPaymentRepo : ICarPaymentRepo
    {
        private DealershipContext _db = new DealershipContext();

        public CarPayment getCarPayment(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarPayment> getCarPayments()
        {
            throw new NotImplementedException();
        }
    }

    //public decimal CalculateCarPayment(Car PrisPrDag, int TotalDag, decimal TotalPayment)
    //{

        

    //        return TotalPayment;
    //}

        //public CarPayment getCarPayment(int id)
        //{
        //    return new List<CarPayment>(_db.CarPayment);
        //}
    
}
