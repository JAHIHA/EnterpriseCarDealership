﻿using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.Car;

namespace EnterpriseCarDealership.service_repository_s
{
    public interface ICarService
        //KARZAN
    {
        public List<Car> GetCarList();

        public Task Addcar(CreateCar car);


        public Task Updatecar(Car car);


        public Car GetCarById(int id);

        public Task Deletecar(int id);

    }
}
