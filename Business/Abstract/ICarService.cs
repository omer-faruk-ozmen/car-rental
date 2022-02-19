
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car entity);
        void Delete(Car entity);
        void Update(Car entity);
        List<Car> GetAll();
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByUnitPrice(int min, int max);

        List<CarDetailDto> GetCarDetails();
    }
}
