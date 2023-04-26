namespace EnterpriseCarDealership.Models
{
    //KARZAN
    public class Car: Vehicle
    {
        public bool AC { get; set; }
        public bool Sunroof { get; set; }

        public bool Screen { get; set; }    

        public bool DVD { get; set; }   
        public bool Camera { get; set; }
        public bool Sensor { get; set; }

        public Car(int Id, string Brand, MotorType Type, double PrisPrDag, int Year, int Km, bool aC, bool sunroof, bool screen, bool dVD, bool camera, bool sensor) : base(Id, Brand, Type, PrisPrDag, Year, Km)
        {
            AC = aC;
            Sunroof = sunroof;
            Screen = screen;
            DVD = dVD;
            Camera = camera;
            Sensor = sensor;
            

        }

        public override string ToString()
        {
            return $"{{{nameof(AC)}={AC.ToString()}, {nameof(Sunroof)}={Sunroof.ToString()}," +
            $" {nameof(Screen)}={Screen.ToString()}, {nameof(DVD)}={DVD.ToString()}, " +
            $"{nameof(Camera)}={Camera.ToString()}, {nameof(Sensor)}={Sensor.ToString()}, " +
            $"{nameof(Id)}={Id.ToString()}, {nameof(Brand)}={Brand}, {nameof(Type)}={Type.ToString()}, " +
            $"{nameof(PrisPrDag)}={PrisPrDag.ToString()}, {nameof(Year)}={Year.ToString()}, " +
            $"{nameof(Km)}={Km.ToString()}}}";
        }
    }
}
