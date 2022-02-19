using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand entity);
        void Delete(Brand entity);
        void Update(Brand entity);
        List<Brand> GetAll();
        Brand GetById(int id);
    }
}
