namespace EnterpriseCarDealership.Models
{
    public class Car : Vehicle
    {
        //PROPERTY
        public bool AC { get; set; }
        public bool Sunroof { get; set; }

        public bool Screen { get; set; }

        public bool DVD { get; set; }

        public bool Camera { get; set; }

        public bool Sensor { get; set; }


        //CONSTRUCTOR 
        public Car(bool aC, bool sunroof, bool screen, bool dVD, bool camera, bool sensor) : base()
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
            return $"AC: {AC}, Sunroof: {Sunroof}, Screen: {Screen}, DVD: {DVD}, Camera: {Camera}, Sensor: {Sensor}";
        }

    }



}
