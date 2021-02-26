using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfImageDal : IEntityRespositoryBase<Image, ReCarContext>, IImageDal
    {
        public bool IsExist(int id)
        {
            using (ReCarContext context= new ReCarContext())
            {
                return context.Images.Any(ı=> ı.ImageID== id);
            }
        }
    }
}
