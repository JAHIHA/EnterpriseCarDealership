namespace EnterpriseCarDealership.Models
{
    public class Medarbejder : User
    {
        public string Adress { get; set; }
        public Medarbejder()
        {

        }
        public Medarbejder(string adress) : base()
        {
            Adress = adress;
        }
    }
}
