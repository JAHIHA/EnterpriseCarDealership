using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

namespace EnterpriseCarDealership.service_repository_s.Service
{
    public class CarPaymentService : ICarPyamentService
    {
        private ICarPaymentRepo _carPaymentRepo;

        public CarPaymentService(ICarPaymentRepo carPaymentRepo)
        {
            _carPaymentRepo = carPaymentRepo;
        }
    
        public List<CarPayment> getListOfCarPayments()
        {
            return _carPaymentRepo.getCarPayments();
        }

        public CarPayment GetCarPayment(int id)
        {
            return _carPaymentRepo.getCarPayment(id); 
        }

        
    }

}
