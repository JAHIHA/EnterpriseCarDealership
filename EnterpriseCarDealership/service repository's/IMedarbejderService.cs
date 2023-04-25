using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IMedarbejderService
    {
        public List<Medarbejder> GetbookingList();

        public void Addmedarbejder(medarbejder medarbejder);
);


        public void Updatemedarbejder(medarbejder medarbejder);


        public Booking GetmedarbejderById(int id);

        public void Deletemedarbejder(int id);
    }
}
