using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetColors();
        List<Color> GetColorID(int colorID);
        void Add(Color color);
        void Delete(Color color);
        void UpDate(Color color);
    }
}
