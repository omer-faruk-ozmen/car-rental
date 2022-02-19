using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    class EfColorDal : EfEntityRepositoryBase<Color, SqlServerContext>, IColorDal
    {

    }
}
