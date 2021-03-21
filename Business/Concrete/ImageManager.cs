using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Bussiness;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        public ImageManager(IImageDal carDal)
        {
            _imageDal = carDal;
        }


        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IDataResult<List<Image>> GetAllByCarId(int carID)
        {
            var result = _imageDal.GetAll(i => i.CarID == carID);

            if (result.Count > 0)
            {
                return new SuccessDataResult<List<Image>>(result);
            }

            List<Image> images = new List<Image>();
            images.Add(new Image() { CarID = 0, ImageID = 0, ImagePath = "/images/car-rent.png" });

            return new SuccessDataResult<List<Image>>(images);
        }

        public IDataResult<Image> GetById(int imageID)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.ImageID == imageID));
        }

        public IResult Add(IFormFile image, Image carImage)
        {

            var imageCount = _imageDal.GetAll(c => c.CarID == carImage.CarID).Count;

            if (imageCount >= 5)
            {
                return new ErrorResult("One car must have 5 or less images");
            }

            var imageResult = FileUploadHelper.Upload(image);

            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            carImage.ImagePath = imageResult.Message;
            _imageDal.Add(carImage);
            return new SuccessResult("Car image added");
        }

        public IResult Delete(Image carImage)
        {
            var image = _imageDal.Get(c => c.ImageID == carImage.ImageID);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }

            FileUploadHelper.Delete(image.ImagePath);
            _imageDal.Delete(carImage);
            return new SuccessResult("Image was deleted successfully");
        }

        public IResult Update(IFormFile image, Image carImage)
        {
            var isImage = _imageDal.Get(c => c.ImageID == carImage.ImageID);
            if (isImage == null)
            {
                return new ErrorResult("Image not found");
            }

            var updatedFile = FileUploadHelper.Update(image, isImage.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            carImage.ImagePath = updatedFile.Message;
            _imageDal.Update(carImage);
            return new SuccessResult("Car image updated");

        }
    }
}
