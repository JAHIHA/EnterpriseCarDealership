namespace EnterpriseCarDealership.Models
{
    public class Medarbejder : User
    {
        public string Adress { get; set; }
        public int ManagerId { get; set; }      
        public Medarbejder()
        {
            Adress = "nowhere";
            ManagerId = 0;
        }
        public Medarbejder(string adress, int managerId) : base()
        {
            Adress = adress;
            ManagerId = managerId;
        }
    }
}
