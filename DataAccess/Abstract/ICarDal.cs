using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetail(Expression<Func<Car, bool>> filter = null);
    }
}
