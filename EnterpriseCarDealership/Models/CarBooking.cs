﻿using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

namespace EnterpriseCarDealership.Models
{
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
    public class CarBooking
    {
       
        
        public int Id { get; set; }
========
    public class BikeBooking
    {
            public int ID { get; set; }
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs

            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int KundeId { get; set; }
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
            public int CarId { get; set; }
      
        public Car Car { get; set; }
        public Kunde Kunde { get; set; }

            private readonly ICarBookingService BookingService;

            public CarBooking()
========
       
        public int BikeId { get; set; }
        public int PaymentId { get; set; }

        private readonly IBikeBookingService BookingService;

        public BikeBooking()
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
            {

            }


<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
        public CarBooking(int ID, DateTime StartTime, DateTime EndTime, int KundeId, int CarId, int BikeId, int PaymentId)
========


        public BikeBooking(int ID, DateTime StartTime, DateTime EndTime, int KundeId, int CarId, int BikeId, int PaymentId)
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
            {
                if (ID == default) throw new ArgumentOutOfRangeException(nameof(ID), "Booking Id is required");
                if (StartTime == default) throw new ArgumentOutOfRangeException(nameof(StartTime), "StartTime date is required");
                if (EndTime == default) throw new ArgumentOutOfRangeException(nameof(EndTime), "EndTime date is required");
                if (KundeId == default) throw new ArgumentOutOfRangeException(nameof(KundeId), "Customer id is required");
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
                if (CarId == default) throw new ArgumentOutOfRangeException(nameof(CarId), "Car id  is required");
          
========
            if (BikeId == default) throw new ArgumentOutOfRangeException(nameof(BikeId), "Bike id  is required");
                if (PaymentId == default) throw new ArgumentOutOfRangeException(nameof(PaymentId), "Payment id  is required");
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
                if (StartTime >= EndTime) throw new Exception($"EndTime has to come later than StartTime (StartTime, EndTime): {StartTime}, {EndTime}");
            this.Id = ID;
                this.StartTime = StartTime;
                this.EndTime = EndTime;
                this.KundeId = KundeId;
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
                this.CarId = CarId;
           

        }
        public CarBooking(int _id, DateTime _startTime, DateTime _endTime, int _kundeID, int _carId, ICarBookingService _services, int _paymentId)
========
            this.BikeId = BikeId;
                this.PaymentId = PaymentId;

            }
        public BikeBooking(int _id, DateTime _startTime, DateTime _endTime, int _kundeID, int _carId, int _bikeId, IBikeBookingService _services, int _paymentId)
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
            {
                if (_id == default) throw new ArgumentOutOfRangeException(nameof(_id), "Booking Id is required");
                if (_startTime == default) throw new ArgumentOutOfRangeException(nameof(_startTime), "Start time date is required");
                if (_endTime == default) throw new ArgumentOutOfRangeException(nameof(_endTime), "End Time date is required");
                if (_kundeID == default) throw new ArgumentOutOfRangeException(nameof(_kundeID), "Customer id is required");
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
                if (_carId == default) throw new ArgumentOutOfRangeException(nameof(_carId), "Car id  is required");
           
========
            if (_bikeId == default) throw new ArgumentOutOfRangeException(nameof(_bikeId), "Bike id  is required");
                if (_paymentId == default) throw new ArgumentOutOfRangeException(nameof(_paymentId), "Payment id  is required");
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
                if (_startTime >= _endTime) throw new Exception($"End time has to come later than Start Time (StartTime, End): {_startTime}, {_endTime}");
            Id = _id;
                StartTime = _startTime;
                EndTime = _endTime;
                KundeId = _kundeID;
<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs
                CarId = _carId;
                BookingService = _services;
           
========
            BikeId = _bikeId;
            BookingService = _services;
                PaymentId = _paymentId;
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
            }
        }

    }

<<<<<<<< HEAD:EnterpriseCarDealership/Models/CarBooking.cs

========
>>>>>>>> 88d639a766030b1c9cbec63b899dd3f5c046a922:EnterpriseCarDealership/Models/BikeBooking.cs
