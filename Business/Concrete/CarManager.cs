using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Bussiness;
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
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetByCarID(int carID)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarID == carID));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExists(car.CarName), CheckIfCarCountOfBrandCorrect(car.BrandID));
            if (result!=null)
            {
                return result;
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }
            
        public IDataResult<List<Car>> GetByCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarByBrandID(int brandID)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandID == brandID));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
   
        }

        public IDataResult<List<Car>> GetCarByColorID(int colorID)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.ColorID==colorID));
        }

        public IDataResult<List<Car>> GetCarByModelYear(int date)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear == date));
        }

        public IDataResult<List<Car>> GetCarByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<Car>> GetCarByDescription(string carDescription)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.Description== carDescription));
        }

        public IResult Delete(Car car)
        {

            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult UpDate(Car car)
        {

            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }

        private IResult CheckIfCarCountOfBrandCorrect(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandID == brandId).Count;
            if (result>= 15)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExits);
            }
            return new SuccessResult();
        }
    }
}
