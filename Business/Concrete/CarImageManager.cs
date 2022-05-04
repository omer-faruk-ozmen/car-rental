using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;
        private IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return new ErrorResult(result.Message) ;
            }
            carImage.ImagePath = _fileHelper.Upload(file, ImagePathFixed.ImagesPath);
            _carImageDal.Add(carImage);
            return new SuccessResult(message:"Araç resmi eklendi");
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(ImagePathFixed.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(message:"Araç resmi silindi");
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            _fileHelper.Update(file, ImagePathFixed.ImagesPath + carImage.ImagePath, ImagePathFixed.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult(message: "Araç resmi güncellendi");
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckCarIsHaveImage(carId));
            if (result != null)
            {
                return new SuccessDataResult<List<CarImage>>(GetDefaultImage());
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        private List<CarImage> GetDefaultImage()
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage{ImagePath="DefaultImage.png"});
            return carImage;
        }

        private IResult CheckCarIsHaveImage(int carId)
        {
            if (_carImageDal.GetAll(c => c.CarId == carId).Count == 0)
            {
                return new ErrorResult(message: "Araç resmi bulunamadı");
            }

            return new SuccessResult();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult(message: "Araç resim limiti (5)");
            }
            return new SuccessResult();
        }
    }
}
