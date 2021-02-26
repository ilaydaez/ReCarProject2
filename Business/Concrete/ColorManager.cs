using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
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
            ValidationTool.Validate(new ColorValidator(), color);

            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            

            _colorDal.Delete(color);

            return new SuccessResult(Messages.ColorDeleted);
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
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _colorDal.Update(color);

            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
