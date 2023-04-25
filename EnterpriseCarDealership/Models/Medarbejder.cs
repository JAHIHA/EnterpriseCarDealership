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
        public Medarbejder(int id, string name, string password, bool isAdmin, string tlf,string adress, int managerId) : base(id, name, password, isAdmin,tlf )
        {
            Adress = adress;
            ManagerId = managerId;
        }

        public override string ToString()
        {
            return $"{{{nameof(Adress)}={Adress}, {nameof(ManagerId)}={ManagerId.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
