namespace EnterpriseCarDealership.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password {get; set; }
        public string Tlf { get; set; }

        public User()
        {
            Id = -1;
            Name = "dummy";
            Password = "dummy";
            Tlf = "00000000";
            
        }
        public User(int id, string name, string password, string tlf)
        {
            Id = id;
            Name = name;
            Password = password;
            Tlf = tlf;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
