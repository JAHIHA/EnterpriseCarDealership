using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface Interface
    {
        public List<booking> GetbookingList();

        public void Addbooking(booking booking);


        public void Updatebooking(booking booking);


        public Kunde GetbookingById(int id);

        public void Deletebooking(int id);
    }
}
