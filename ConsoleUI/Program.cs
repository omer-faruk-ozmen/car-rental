using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();

            //UserTest();
            //CustomerTest();
            //RentalTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var car in result.Data)
                {

                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
        }


        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CompanyName = "Avis", UserId = 1 });
            Console.WriteLine(result.Message);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 3, CustomerId = 1, RentDate = new DateTime(2022, 2, 20)});
            Console.WriteLine(result.Message);
       
        }
    }
}
