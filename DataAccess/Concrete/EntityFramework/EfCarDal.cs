using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarForDeleteDto> GetCars()
        {
            using (ReCarContext context = new ReCarContext())
            {
                IQueryable<CarForDeleteDto> carForDelete = from c in context.Cars
                                                           join r in context.Rentals
                                                           on c.CarID equals r.CarID
                                                           select new CarForDeleteDto
                                                           {
                                                               CarID = c.CarID,
                                                               ID = r.ID,
                                                               RentedDate = r.RentDate,
                                                               ReturnedDate = r.ReturnDate
                                                           };
                return carForDelete.ToList();

            }
        }

        public List<CarDetailsDto> GetCarDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCarContext context = new ReCarContext())
            {
                IQueryable<CarDetailsDto> carDetails = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                                                      join b in context.Brands
                                                      on c.BrandID equals b.BrandID
                                                      join cl in context.Colors
                                                      on c.ColorID equals cl.ColorID
                                                      select new CarDetailsDto
                                                      {
                                                          CarID = c.CarID,
                                                          BrandID = b.BrandID,
                                                          ColorID = cl.ColorID,
                                                          CarName = c.CarName,
                                                          BrandName = b.BrandName,
                                                          ColorName = cl.ColorName,
                                                          ModelYear = c.ModelYear,
                                                          DailyPrice = c.DailyPrice.ToString(),
                                                          Description = c.Description,

                                                      };

                return carDetails.ToList();
            }
        }
    }
}
