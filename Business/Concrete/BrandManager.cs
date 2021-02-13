using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Massages.BrandNameInvalid);
            }

            _brandDal.Add(brand);

            return new SuccessResult(Massages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            

            _brandDal.Delete(brand);

            return new SuccessResult(Massages.BrandAdded);
        }


        public IDataResult<List<Brand>> GetCarByBrand()
        {
            return new SuccessDataResult<List<Brand>>(  _brandDal.GetAll());
        }

        public IDataResult<Brand> GetCarByBrandID(int brandID)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandID == brandID));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Massages.BrandNameInvalid);
            }

            _brandDal.Update(brand);

            return new SuccessResult(Massages.BrandAdded);
        }
    }
}
