using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace EnterpriseCarDealership.Models
{
    public class User
    {
        public  int NextId { get; set; }
        public string Name { get; set; }
        public string Password {get; set; }
        public bool IsMedarbejder { get; set; }
        public bool IsAdmin { get; set; }
        public string? Tlf { get; set; }


        //Regex r = new Regex(@"^((\+)?\d{2}(\s|\-)?)?\d{8}$");
        //string[] phone = { "+45-88888888", "+45 88888888", "45 88888888", "45-88888888", "88888888" };

        //public string Tlf
        //{
        //    get => _mobil;
        //    set
        //    {
        //        foreach (string numbers in phone)
        //        {
        //            if (!(r.IsMatch(value)))
        //            {
        //                throw new ArgumentException("Mobil skal have mellem 8 og 12 tegn");
        //            }
        //        }
        //        _mobil = value;
        //    }
        //}

        [JsonConstructor]
        public User(int NextId, string Name, string Password, bool isMedarbejder, bool isAdmin, string Tlf)
        {
            this.NextId = NextId;
            this.Name = Name;
            this.Password = Password;
            this.IsMedarbejder = isMedarbejder;
            this.IsAdmin = isAdmin;
            this.Tlf = Tlf;

        }
        public User()
        {
            NextId = -1;
            Name = "dummy";
            Password = "dummy";
            IsMedarbejder = false;
            IsAdmin = false;
            Tlf = "00000000";

        }
    


        public override string ToString()
        {
            return $"{{{nameof(NextId)}={NextId.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsMedarbejder)}={IsMedarbejder.ToString()}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
