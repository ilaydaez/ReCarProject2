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
        public List<CarDetailsDto> GetCarDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join co in context.Colors
                             on c.ColorID equals co.ColorID
                             select new CarDetailsDto
                             {
                                 CarID = c.CarID,
                                 BrandID = b.BrandID,
                                 ColorID = co.ColorID,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice.ToString(),
                                 Description = c.Description,
                                 ImagePath = context.Images.Where(x => x.CarID == c.CarID).FirstOrDefault().ImagePath
                             };
                return result.ToList();
            }

        }

    }

    
}
