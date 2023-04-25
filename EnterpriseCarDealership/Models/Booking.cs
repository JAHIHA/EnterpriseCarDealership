namespace EnterpriseCarDealership.Models
{
    public class Booking
    {
        public int ID { get; set; }
       
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int KundeId { get; set; }
        public int CarId { get; set; }
        private readonly IBookingService BookingService;

        public Booking()
        {

        }

        
       

        public Booking(int ID, DateTime StartTime, DateTime EndTime, int KundeId, int CarId)
        {
            if (ID == default) throw new ArgumentOutOfRangeException(nameof(ID), "Booking Id is required");
            if (StartTime == default) throw new ArgumentOutOfRangeException(nameof(StartTime), "StartTime date is required");
            if (EndTime == default) throw new ArgumentOutOfRangeException(nameof(EndTime), "EndTime date is required");
            if (KundeId == default) throw new ArgumentOutOfRangeException(nameof(KundeId), "Customer id is required");
            if (CarId == default) throw new ArgumentOutOfRangeException(nameof(CarId), "Car id  is required");
            if (StartTime >= EndTime) throw new Exception($"EndTime has to come later than StartTime (StartTime, EndTime): {StartTime}, {EndTime}");
            this.ID = ID;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.KundeId = KundeId;
            this.CarId = CarId;


        }
        public Booking(int _id, DateTime _startTime, DateTime _endTime, int _kundeID, int _carId, IBookingService _services)
        {
            if (_id == default) throw new ArgumentOutOfRangeException(nameof(_id), "Booking Id is required");
            if (_startTime == default) throw new ArgumentOutOfRangeException(nameof(_startTime), "Start time date is required");
            if (_endTime == default) throw new ArgumentOutOfRangeException(nameof(_endTime), "End Time date is required");
            if (_kundeID == default) throw new ArgumentOutOfRangeException(nameof(_kundeID), "Customer id is required");
            if (_carId == default) throw new ArgumentOutOfRangeException(nameof(_carId), "Car id  is required");
            if (_startTime >= _endTime) throw new Exception($"End time has to come later than Start Time (StartTime, End): {_startTime}, {_endTime}");
            ID = _id;
            StartTime = _startTime;
            EndTime = _endTime;
            KundeId = _kundeID;
            CarId = _carId;
            BookingService = _services;
        }
    }
}
