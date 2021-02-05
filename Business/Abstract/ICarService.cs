using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetCarsByBrandID(int ID);
        List<Car> GetCarsByColorID(int ID);

    }
}
