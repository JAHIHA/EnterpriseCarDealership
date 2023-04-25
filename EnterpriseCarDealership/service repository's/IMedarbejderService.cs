using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface IMedarbejderService
    {
        public List<Medarbejder> GetmedarbejderList();

        public void Addmedarbejder(Medarbejder medarbejder);
);


        public void Updatemedarbejder(Medarbejder medarbejder);


khaled
        public Medarbejder GetmedarbejderById(int id);

        public Booking GetmedarbejderById(int id);
 master

        public void Deletemedarbejder(int id);
    }
}
