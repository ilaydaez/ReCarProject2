using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _cars.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandID(int ID)
        {
            return _cars.GetAll(c=> c.BrandID==ID);
        }

        public List<Car> GetCarsByColorID(int ID)
        {
            return _cars.GetAll(c=> c.ColorID==ID);
        }
    }
}
