using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace EnterpriseCarDealership.Models
{
    public class Manager:User
    {
        public Manager(int Id, string Name, string password,bool IsMedarbejder, bool isAdmin, string tlf) : base(Id, Name, password, IsMedarbejder , isAdmin, tlf)
        {
           
        }
        public Manager()
        {

        }

        public override string ToString()
        {
            return $"{{{nameof(NextId)}={NextId.ToString()}, {nameof(Name)}={Name}, {nameof(Password)}={Password}, {nameof(IsMedarbejder)}={IsMedarbejder.ToString()}, {nameof(IsAdmin)}={IsAdmin.ToString()}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
