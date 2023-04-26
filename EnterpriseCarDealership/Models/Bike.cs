﻿using DocumentFormat.OpenXml.Office2010.Excel;

namespace EnterpriseCarDealership.Models
{
    //KARZAN
    public class Bike: Vehicle
    {
        public bool Sidebike { get; set; }
        public bool LeatherSddle { get; set; }
        public bool ExtraStorage { get; set; }
        public Bike()
        {

        }
        public Bike(int Id, string Brand, MotorType Type, double PrisPrDag, int Year, int Km, bool sidebike, bool leatherSddle, bool extraStorage) : base(Id,  Brand, Type, PrisPrDag, Year, Km)
        {
            Sidebike = sidebike;
            LeatherSddle = leatherSddle;
            ExtraStorage = extraStorage;
        }

        public override string ToString()
        {
            return $"{{{nameof(Sidebike)}={Sidebike.ToString()}, {nameof(LeatherSddle)}={LeatherSddle.ToString()}, " +
                $"{nameof(ExtraStorage)}={ExtraStorage.ToString()}, {nameof(Id)}={Id.ToString()}, " +
                $"{nameof(Brand)}={Brand}, {nameof(Type)}={Type.ToString()}, {nameof(PrisPrDag)}={PrisPrDag.ToString()}, " +
                $"{nameof(Year)}={Year.ToString()}, {nameof(Km)}={Km.ToString()}}}";
        }
    }
}
