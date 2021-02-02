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
    }
}
