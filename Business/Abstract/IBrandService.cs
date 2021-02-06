using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetCarByBrand();
        List<Brand> GetCarByBrandID(int brandID);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);
    }
}
