namespace EnterpriseCarDealership.Models
{
    public class Kunde:User 
    {
        public string Adress { get; set; }

        public Kunde()
        {
            Adress = "nowhere";
        }
        public Kunde(int Id, string Name,string password, bool isAdmin, string tlf, string adress) : base(Id,Name,password,isAdmin,tlf)
        {
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{{{nameof(Adress)}={Adress}, {nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
