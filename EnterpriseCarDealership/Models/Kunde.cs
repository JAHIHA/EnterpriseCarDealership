namespace EnterpriseCarDealership.Models
{
    public class Kunde:User
    {
        public string Adress { get; set; }
        public Kunde()
        {
            Adress = "nowhere";
        }
        public Kunde(string adress) : base()
        {
            Adress = adress;
        }
    }
}
