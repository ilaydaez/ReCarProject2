using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car{CarID=1, BrandID=1, BrandName="Opel", ColorID=1, ColorName="Siyah", ModelYear=2010, DailyPrice=500, Description="Otomotik Disiel" },
                new Car{CarID=2, BrandID=1, BrandName="Toyota", ColorID=2, ColorName="Beyaz", ModelYear=2018, DailyPrice=600, Description="Otomotik Benzinli" },
                new Car{CarID=3, BrandID=2, BrandName="Hyundai", ColorID=2, ColorName="Beyaz", ModelYear=2019, DailyPrice=550, Description="Manuel Disiel" },
                new Car{CarID=4, BrandID=2, BrandName="Opel", ColorID=1, ColorName="Siyah", ModelYear=2020, DailyPrice=550, Description="Otomotik Disiel" },

            };
        }

        public void Add(Car cars)
        {
            _cars.Add(cars);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BrandName : " + cars.BrandName + "   " +
                    "ColorName : " + cars.ColorName + "   " +
                    "DailyPrice : " + cars.DailyPrice + "   " +
                    "ModelYear : " + cars.ModelYear + "   " +
                    "Description : " + cars.Description);
            Console.ResetColor();
        }

        public void Delete(int CarID)
        {

            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == CarID);
            _cars.Remove(carToDelete);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BrandName : " + carToDelete.BrandName + "   " +
                    "ColorName : " + carToDelete.ColorName + "   " +
                    "DailyPrice : " + carToDelete.DailyPrice + "   " +
                    "ModelYear : " + carToDelete.ModelYear + "   " +
                    "Description : " + carToDelete.Description);
            Console.ResetColor();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car cars)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == cars.CarID);
            carToUpdate.BrandID = cars.BrandID;
            carToUpdate.BrandName = cars.BrandName;
            carToUpdate.ColorID = cars.ColorID;
            carToUpdate.ColorName = cars.ColorName;
            carToUpdate.DailyPrice = cars.DailyPrice;
            carToUpdate.Description = cars.Description;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BrandName : " + cars.BrandName + "   " +
                    "ColorName : " + cars.ColorName + "   " +
                    "DailyPrice : " + cars.DailyPrice + "   " +
                    "ModelYear : " + cars.ModelYear + "   " +
                    "Description : " + cars.Description);
            Console.ResetColor();

        }
    }
}
