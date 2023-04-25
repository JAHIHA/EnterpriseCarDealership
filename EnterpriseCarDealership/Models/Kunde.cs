namespace EnterpriseCarDealership.Models
{
    public class Booking:User
    {
        public string Adress { get; set; }
        public Booking()
        {
            Adress = "nowhere";
        }
        public Booking(string adress) : base()
        {
            Adress = adress;
        }
    }
}
