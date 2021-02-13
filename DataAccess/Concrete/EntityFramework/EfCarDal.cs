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
    public class EfCarDal : IEntityRespositoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join r in context.Colors
                             on c.ColorID equals r.ColorID
                             
                             
  
                             select new CarDetailsDto
                             {
                                 CarID = c.CarID,
                                 CarName = c.CarName,
                                 BrandID=b.BrandID,
                                 BrandName = b.BrandName,
                                 ColorID=r.ColorID,
                                 ColorName=r.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear,
                                 Description=c.Description,
                                 
   
                             };

                return result.ToList();
            }

        }
        

    }
}
