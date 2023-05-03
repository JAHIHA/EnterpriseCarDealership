﻿using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class CarBookingRepo : ICarBookingRepo
    {
        private DealershipContext _Carbookdb = new DealershipContext();

        public async Task Addcarbooking(CarBooking Carbooking)
        {
            _Carbookdb.CarBooking.Add(Carbooking);
            await _Carbookdb.SaveChangesAsync();

        }

        public async Task DeleteCarbooking(int id)
        {
            CarBooking? Carbooking = GetCarbookingById(id);
            _Carbookdb.CarBooking.Remove(Carbooking);
            await _Carbookdb.SaveChangesAsync();
        }

        public CarBooking GetCarbookingById(int id)
        {
            CarBooking Carbooking = GetCarbookingList().FirstOrDefault(x => x.ID == id);
            return Carbooking;
        }

   

        public async Task UpdateCarbooking(CarBooking Carbooking)
        {
            CarBooking book = GetCarbookingById(Carbooking.ID);


            Carbooking.StartTime = book.StartTime;
            Carbooking.EndTime = book.EndTime;
            Carbooking.KundeId = book.KundeId;
            Carbooking.CarId = book.CarId;
            Carbooking.PaymentId = book.PaymentId;
            _Carbookdb.CarBooking.Update(book);
            await _Carbookdb.SaveChangesAsync();

        }

        public List<CarBooking> GetCarbookingList()
        {
            return new List<CarBooking>(_Carbookdb.CarBooking);
        }

        public async Task AddCarbooking(CarBooking carbooking)
        {
            _Carbookdb.CarBooking.Add(carbooking);
            await _Carbookdb.SaveChangesAsync();

        }
    }
}
