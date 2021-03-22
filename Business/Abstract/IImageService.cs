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
        IDataResult<List<Image>> GetByImageID(int ımageID);
        IDataResult<List<Image>> GetByImages();
        IDataResult<List<Image>> GetImageByCarID(int carID);
        IDataResult<List<Image>> GetImageByDate(DateTime ımageDate);
        IResult Add(Image ımage);
        IResult Delete(Image ımage);
        IResult UpDate(Image ımage);
    }
}
