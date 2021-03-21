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
        IDataResult<List<CarDetailsDto>> GetCarByBrandID(int brandId);
        IDataResult<List<CarDetailsDto>> GetCarByColorID(int colorID);
        IDataResult<List<Car>> GetCarByModelYear(int date);
        IDataResult<List<Car>> GetCarByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarByDescription(string carDescription);
        IDataResult<List<CarDetailsDto>> GetCarDetail();
        IDataResult<List<CarDetailsDto>> GetCarByDetailId(int carID);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult UpDate(Car car);

        IResult AddTransactionalTest(Car car);




    }
}
