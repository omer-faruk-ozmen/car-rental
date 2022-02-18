using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }


            foreach (var car in carManager.GetAllByBrandId(id:1))
            {
                Console.WriteLine(car.CarName);
            }

            foreach (var car in carManager.GetAllByColorId(id:1))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetByUnitPrice(min:100,max:180))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
