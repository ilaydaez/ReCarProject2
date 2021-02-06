using Business.Abstract;
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

        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetColorID(int colorID)
        {
            return _colorDal.GetAll(c => c.ColorID == colorID);
        }


        public List<Color> GetColors()
        {
            return _colorDal.GetAll();
        }

        public void UpDate(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
