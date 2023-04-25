using DocumentFormat.OpenXml.Office2010.Excel;

namespace EnterpriseCarDealership.Models
{
    public class Bike: Vehicle
    {
        public bool Sidebike { get; set; }
        public bool LeatherSddle { get; set; }
        public bool ExtraStorage { get; set; }
        public Bike()
        {

        }
        public Bike(bool sidebike, bool leatherSddle, bool extraStorage) : base( )
        {
            Sidebike = sidebike;
            LeatherSddle = leatherSddle;
            ExtraStorage = extraStorage;
        }
    }
}
