using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    BrandId = 1,
                    ColorId = 1,
                    DailyPrice = 750,
                    Description = "C sınıfı 2 yıl ehlitetli kişi kiralayabilir",
                    Id = 1,
                    ModelYear = 2022
                },
                new Car
                {
                    BrandId = 2,
                    ColorId =3,
                    DailyPrice = 250,
                    Description = "B sınıfı 2 yıl ehlitetli kişi kiralayabilir",
                    Id = 2,
                    ModelYear = 2018
                },
                new Car
                {
                    BrandId = 1,
                    ColorId = 1,
                    DailyPrice = 350,
                    Description = "D sınıfı 2 yıl ehlitetli kişi kiralayabilir",
                    Id = 3,
                    ModelYear = 2019
                },
                new Car
                {
                    BrandId = 1,
                    ColorId = 1,
                    DailyPrice = 150,
                    Description = "B sınıfı 2 yıl ehlitetli kişi kiralayabilir",
                    Id =4,
                    ModelYear = 2016
                }
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
