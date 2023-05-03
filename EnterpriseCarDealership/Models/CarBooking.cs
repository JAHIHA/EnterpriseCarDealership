﻿using EnterpriseCarDealership.service_repository_s;

namespace EnterpriseCarDealership.Models
{
    public class CarBooking
    {
       
        
            public int ID { get; set; }

            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int KundeId { get; set; }
            public int CarId { get; set; }
            public int PaymentId { get; set; }
            private readonly ICarBookingService BookingService;

            public CarBooking()
            {

            }




            public CarBooking(int ID, DateTime StartTime, DateTime EndTime, int KundeId, int CarId, int BikeId, int PaymentId)
            {
                if (ID == default) throw new ArgumentOutOfRangeException(nameof(ID), "Booking Id is required");
                if (StartTime == default) throw new ArgumentOutOfRangeException(nameof(StartTime), "StartTime date is required");
                if (EndTime == default) throw new ArgumentOutOfRangeException(nameof(EndTime), "EndTime date is required");
                if (KundeId == default) throw new ArgumentOutOfRangeException(nameof(KundeId), "Customer id is required");
                if (CarId == default) throw new ArgumentOutOfRangeException(nameof(CarId), "Car id  is required");
                if (PaymentId == default) throw new ArgumentOutOfRangeException(nameof(PaymentId), "Payment id  is required");
                if (StartTime >= EndTime) throw new Exception($"EndTime has to come later than StartTime (StartTime, EndTime): {StartTime}, {EndTime}");
                this.ID = ID;
                this.StartTime = StartTime;
                this.EndTime = EndTime;
                this.KundeId = KundeId;
                this.CarId = CarId;
                this.PaymentId = PaymentId;

            }
            public CarBooking(int _id, DateTime _startTime, DateTime _endTime, int _kundeID, int _carId, ICarBookingService _services, int _paymentId)
            {
                if (_id == default) throw new ArgumentOutOfRangeException(nameof(_id), "Booking Id is required");
                if (_startTime == default) throw new ArgumentOutOfRangeException(nameof(_startTime), "Start time date is required");
                if (_endTime == default) throw new ArgumentOutOfRangeException(nameof(_endTime), "End Time date is required");
                if (_kundeID == default) throw new ArgumentOutOfRangeException(nameof(_kundeID), "Customer id is required");
                if (_carId == default) throw new ArgumentOutOfRangeException(nameof(_carId), "Car id  is required");
                if (_paymentId == default) throw new ArgumentOutOfRangeException(nameof(_paymentId), "Payment id  is required");
                if (_startTime >= _endTime) throw new Exception($"End time has to come later than Start Time (StartTime, End): {_startTime}, {_endTime}");
                ID = _id;
                StartTime = _startTime;
                EndTime = _endTime;
                KundeId = _kundeID;
                CarId = _carId;
                BookingService = _services;
                PaymentId = _paymentId;
            }
        }
    }

