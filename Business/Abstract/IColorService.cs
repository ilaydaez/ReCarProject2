using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetColors();
        IDataResult<Color> GetColorID(int colorID);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult UpDate(Color color);
    }
}
