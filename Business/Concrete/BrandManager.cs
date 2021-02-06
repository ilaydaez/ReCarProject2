using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }


        public List<Brand> GetCarByBrand()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetCarByBrandID(int brandID)
        {
            return _brandDal.GetAll(c => c.BrandID == brandID);
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
