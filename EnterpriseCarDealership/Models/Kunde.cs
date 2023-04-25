namespace EnterpriseCarDealership.Models
{
    public class Kunde:User
    {
        public string Adress { get; set; }
        public Kunde()
        {

        }
        public Kunde(string adress) : base()
        {
            Adress = adress;
        }
    }
}
