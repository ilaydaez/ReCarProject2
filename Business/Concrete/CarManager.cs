using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cars;

        public CarManager(ICarDal carDal)
        {
            _cars = carDal;
        }

        public IDataResult<List<Car>> GetByCarID(int carID)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.CarID == carID));
        }


        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _cars.Add(car);

            return new SuccessResult(Massages.CarAdded);

            //using (ReCarContext context = new ReCarContext())
            //{
            //    var addedEntity = context.Entry(car);
            //    addedEntity.State = EntityState.Added;
            //    context.SaveChanges();

            //}
        }
            
        public IDataResult<List<Car>> GetByCars()
        {
            //if (DateTime.Now.Hour >= 23)
            //{
            //    return new ErrorDataResult<List<Car>>(Massages.MaintenanceTime);

            //}
            return new SuccessDataResult<List<Car>>(_cars.GetAll(), Massages.CarListed);
        }

        public IDataResult<List<Car>> GetCarByBrandID(int brandID)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.BrandID == brandID));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_cars.GetCarDetails());
   
        }

        public IDataResult<List<Car>> GetCarByColorID(int colorID)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c=> c.ColorID==colorID));
        }

        public IDataResult<List<Car>> GetCarByModelYear(int date)
        {
            return new SuccessDataResult<List<Car>>( _cars.GetAll(c => c.ModelYear == date));
        }

        public IDataResult<List<Car>> GetCarByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>( _cars.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<Car>> GetCarByDescription(string carDescription)
        {
            return new SuccessDataResult<List<Car>>( _cars.GetAll(c=> c.Description== carDescription));
        }

        public IResult Delete(Car car)
        {
  
            _cars.Delete(car);

            return new SuccessResult(Massages.CarDeleted);
            

            //using (ReCarContext context = new ReCarContext())
            //{
            //    var deletedEntity = context.Entry(car);
            //    deletedEntity.State = EntityState.Deleted;
            //    context.SaveChanges();

            //}
        }

        public IResult UpDate(Car car)
        {

            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Massages.CarNameInvalid);
            }

            _cars.Update(car);

            return new SuccessResult(Massages.CarUpdated);

            //using (ReCarContext context = new ReCarContext())
            //{
            //    var updatedEntity = context.Entry(car);
            //    updatedEntity.State = EntityState.Modified;
            //    context.SaveChanges();

            //    Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-20} | {4,-15} | {5,-20} | {6,-20} ", car.CarID,
            //                car.CarName, car.BrandID, car.ColorID, car.ModelYear, car.DailyPrice, car.Description));
            //}
        }
    }
}
