﻿namespace EnterpriseCarDealership.Models
{
    public abstract class User
    {
        public  int NextId { get; set; }
        public string Name { get; set; }
        public string Password {get; set; }
        public bool IsMedarbejder { get; set; }
        public bool IsAdmin { get; set; }
        public string Tlf { get; set; }

        public User()
        {
            NextId = -1;
            Name = "dummy";
            Password = "dummy";
            IsMedarbejder = false;
            IsAdmin = false;
            Tlf = "00000000";
            
        }
        public User(int id, string name, string password, bool isMedarbejder, bool isAdmin, string tlf)
        {
            id = NextId++;
            Name = name;
            Password = password;
            IsMedarbejder = isMedarbejder;
            IsAdmin = isAdmin;
            Tlf = tlf;
            
        }

        public override string ToString()
        {
            return $"{{{nameof(NextId)}={NextId.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsMedarbejder)}={IsMedarbejder.ToString()}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
