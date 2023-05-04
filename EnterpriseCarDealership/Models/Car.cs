namespace EnterpriseCarDealership.Models
{
    //KARZAN

    public class Car
    {
        public int NextId { get; set; }
        public string Brand { get; set; }
        public MotorType Type { get; set; }
        public double PrisPrDag { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public bool AC { get; set; }
        public bool Sunroof { get; set; }

        public bool Screen { get; set; }

        public bool DVD { get; set; }
        public bool Camera { get; set; }
        public bool Sensor { get; set; }

        public Car()
        {

        }
        public Car(int Id, string Brand, MotorType Type, double PrisPrDag, int Year, int Km, bool aC, bool sunroof, bool screen, bool dVD, bool camera, bool sensor, int nextId, string brand)
        {

            NextId = nextId;
            AC = aC;
            Sunroof = sunroof;
            Screen = screen;
            DVD = dVD;
            Camera = camera;
            Sensor = sensor;

        }
        public Car(string brand)
        {

        }

        public override string ToString()
        {
            return $"{{{nameof(AC)}={AC.ToString()}, {nameof(Sunroof)}={Sunroof.ToString()}," +
            $" {nameof(Screen)}={Screen.ToString()}, {nameof(DVD)}={DVD.ToString()}, " +
            $"{nameof(Camera)}={Camera.ToString()}, {nameof(Sensor)}={Sensor.ToString()}, " +
            $"{nameof(NextId)}={NextId.ToString()}, {nameof(Brand)}={Brand}, {nameof(Type)}={Type.ToString()}, " +
            $"{nameof(PrisPrDag)}={PrisPrDag.ToString()}, {nameof(Year)}={Year.ToString()}, " +
            $"{nameof(Km)}={Km.ToString()}}}";
        }
    }
}
