namespace EnterpriseCarDealership.Models
{

    public class Kunde : User
    {
        //KARZAN
        public string Adress { get; set; }

        public Kunde()
        {
            Adress = "nowhere";
        }
        public Kunde(int Id, string Name, string password, bool IsMedarbejder, bool isAdmin, string tlf, string adress) : base(Id, Name, password, IsMedarbejder, isAdmin, tlf)
        {
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{{{nameof(Adress)}={Adress}, {nameof(NextId)}={NextId.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsMedarbejder)}={IsMedarbejder.ToString()}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
    
}
