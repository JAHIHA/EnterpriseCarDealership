using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.Service.Interface

{
    public interface ICarPyamentService
    {
        public List<CarPayment> getListOfCarPayments();

        public CarPayment GetCarPayment(int id);

        public CarPayment PaymentCalculater(int id); 

    }
}
