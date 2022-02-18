using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByUnitPrice(int min, int max);

    }
}
