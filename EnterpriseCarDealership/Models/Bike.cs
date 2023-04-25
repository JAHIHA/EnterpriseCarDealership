using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace EnterpriseCarDealership.Models
{
    public class Bike: Vehicle
    {
        //PROPERTY
        public bool Sidebike { get; set; }
        public bool LeatherSaddle { get; set; }
        public bool ExtraStorage { get; set; }
        public Bike()
        {

        }
        //CONSTRUCTOR
        public Bike(bool sidebike, bool leatherSaddle, bool extraStorage) : base( )
        {
            Sidebike = sidebike;
            LeatherSaddle = leatherSaddle;
            ExtraStorage = extraStorage;
        }

        public override string ToString()
        {
            return $"sidebike: {Sidebike}, leathersaddle: {LeatherSaddle}, extrastorage: {ExtraStorage}";
        }
    }
}
