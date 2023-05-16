﻿using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDBooking;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface ICarBookingService
    {
        public List<CarBooking> GetCarbookingList();

        public Task AddCarbooking(CreateCarBooking Cbooking);


        public Task UpdateCarbooking(CarBooking Cbooking);


        public CarBooking GetCarbookingById(int id);

        public Task DeleteCarbooking(int id);

        public (Car car, CarBooking booking) CalculatePayment(int carId, int bookingId); 


    }
}
