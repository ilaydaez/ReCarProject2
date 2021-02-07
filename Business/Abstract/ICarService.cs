using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetByCarID(int carID);
        List<Car> GetByCars();
        List<Car> GetCarByBrandID(int brandID);
        List<Car> GetCarByColorID(int colorID);
        List<Car> GetCarByModelYear(int date);
        List<Car> GetCarByDailyPrice(decimal min, decimal max);
        List<Car> GetCarByDescription(string carDescription);
        void Add(Car car);
        void Delete(Car car);
        void UpDate(Car car);




    }
}
