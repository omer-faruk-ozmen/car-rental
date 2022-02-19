using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("-----------------GetAllByBrandId-----------------");

            foreach (var car in carManager.GetAllByBrandId(id: 1))
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("-----------------GetAllByColorId-----------------");

            foreach (var car in carManager.GetAllByColorId(id: 1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----------------GetByUnitPrice-----------------");
            foreach (var car in carManager.GetByUnitPrice(min: 100, max: 180))
            {
                Console.WriteLine(car.Description);
            }

            /*
            carManager.Add(new Car
            {
                BrandId = 2, CarName = "skoda",
                ColorId = 1,
                DailyPrice = 120,
                Description = "skoda araç",
                ModelYear = 2016
            });
            */

            carManager.Delete(new Car
            {
                Id = 12
            });

            Console.WriteLine("-----------------GetCarDetails-----------------");
            carManager.GetCarDetails();
        }
    }
}
