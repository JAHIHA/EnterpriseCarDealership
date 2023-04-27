using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace EnterpriseCarDealership.Models
{
    public class Manager:User
    {
        public Manager(int Id, string Name, string password, bool isAdmin, string tlf) : base(Id, Name, password, isAdmin, tlf)
        {
           
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
