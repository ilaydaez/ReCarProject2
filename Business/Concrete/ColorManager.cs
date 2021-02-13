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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Massages.CarNameInvalid);
            }

            _colorDal.Add(color);

            return new SuccessResult(Massages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            

            _colorDal.Delete(color);

            return new SuccessResult(Massages.ColorDeleted);
        }

        public IDataResult<Color> GetColorID(int colorID)
        {
            return new SuccessDataResult< Color > (_colorDal.Get(c => c.ColorID == colorID));
        }


        public IDataResult<List<Color>> GetColors()
        {
            return new SuccessDataResult <List< Color >> (_colorDal.GetAll());
        }

        public IResult UpDate(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Massages.CarNameInvalid);
            }

            _colorDal.Update(color);

            return new SuccessResult(Massages.ColorUpdated);
        }
    }
}
