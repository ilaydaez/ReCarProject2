using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetByCarID(int carID);
        IDataResult<List<Car>> GetByCars();
        IDataResult<List<Car>> GetCarByBrandID(int brandID);
        IDataResult<List<Car>> GetCarByColorID(int colorID);
        IDataResult<List<Car>> GetCarByModelYear(int date);
        IDataResult<List<Car>> GetCarByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarByDescription(string carDescription);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult UpDate(Car car);

        IResult AddTransactionalTest(Car car);




    }
}
