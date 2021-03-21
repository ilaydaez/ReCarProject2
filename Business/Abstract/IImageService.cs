using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<List<Image>> GetAllByCarId(int carID);
        IDataResult<Image> GetById(int imageID);
        IResult Add(IFormFile image, Image carImage);
        IResult Delete(Image carImage);
        IResult Update(IFormFile image, Image carImage);
    }
}
