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
        IImageDal _ımageDal;


        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public IResult Add(Image ımage)
        {
            var result = BusinessRules.Run(CheckIfImageCount(ımage.CarID));
            if (result != null)
            {
                return result;
            }
            _ımageDal.Add(ımage);

            return new SuccessResult();
        }

        [ValidationAspect(typeof(ImageValidator))]
        public IResult Delete(Image ımage)
        {
            IResult result = BusinessRules.Run(ImageDelete(ımage));
            if (result != null)
            {
                return result;
            }
            _ımageDal.Delete(ımage);

            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<Image>> GetByImageID(int ımageID)
        {
            return new SuccessDataResult<List<Image>>(_ımageDal.GetAll(c => c.ImageID == ımageID));
        }

        public IDataResult<List<Image>> GetByImages()
        {
            return new SuccessDataResult<List<Image>>(_ımageDal.GetAll(), Messages.ImageListed);
        }

        public IDataResult<List<Image>> GetImageByCarID(int carID)
        {
            return new SuccessDataResult<List<Image>>(CheckIfImageNull(carID));
        }

        public IDataResult<List<Image>> GetImageByDate(DateTime ımageDate)
        {
            return new SuccessDataResult<List<Image>>(_ımageDal.GetAll(c => c.Date == ımageDate));
        }

        [ValidationAspect(typeof(ImageValidator))]
        public IResult UpDate(Image ımage)
        {
            var ımageUpdate = UpdatedFile(ımage).Data;
            _ımageDal.Update(ımage);

            return new SuccessResult(Messages.ImageUpdated);
        }

        private IResult CheckIfImageCount(int carID)
        {
            var ımageCount = _ımageDal.GetAll(ı => ı.CarID == carID).Count;
            if (ımageCount >= 5)
            {
                return new ErrorResult(Messages.FailAddedImageLimit);
            }
            return new SuccessResult();
        }

        private IResult ImageDelete(Image ımage)
        {
            try
            {
                File.Delete(ımage.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        private IDataResult<Image> UpdatedFile(Image ımage)
        {
            var creatingUniqueFilename = Guid.NewGuid().ToString("N") + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + ".jpeg";

            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Images");

            string result = $"{path}\\{creatingUniqueFilename}";

            File.Copy(ımage.ImagePath, path + "\\" + creatingUniqueFilename);

            File.Delete(ımage.ImagePath);

            return new SuccessDataResult<Image>(new Image { ImageID = ımage.ImageID, CarID = ımage.CarID, ImagePath = result, Date = DateTime.Now });
        }


        private IDataResult<Image> CreatedFile(Image ımage, string extension)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Image");
            var creatingUniqueFilename = Guid.NewGuid().ToString("N")
                + "_" + DateTime.Now.Month + "_"
                + DateTime.Now.Day + "_"
                + DateTime.Now.Year + extension;

            string source = Path.Combine(ımage.ImagePath);

            string result = $@"{path}\{creatingUniqueFilename}";

            try
            {

                File.Move(source, path + @"\" + creatingUniqueFilename);
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<Image>(exception.Message);
            }

            return new SuccessDataResult<Image>(new Image { ImageID = ımage.ImageID, CarID = ımage.CarID, ImagePath = result, Date = DateTime.Now }, Messages.ImagesAdded);
        }

        private List<Image> CheckIfImageNull(int carID)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Images\default.jpg");
            var result = _ımageDal.GetAll(ı => ı.CarID == carID).Any();
            if (!result)
            {
                return new List<Image> { new Image { CarID = carID, ImagePath = path, Date = DateTime.Now } };
            }
            return _ımageDal.GetAll(ı => ı.CarID == carID);
        }

    }
}
