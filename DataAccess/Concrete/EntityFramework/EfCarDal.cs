
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SqlServerContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SqlServerContext context = new SqlServerContext())
            {
                var result =
                    from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join cl in context.Colors
                        on c.ColorId equals cl.ColorId
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        CarName = c.CarName,
                        ColorName = cl.ColorName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();

            }
        }
    }
}
