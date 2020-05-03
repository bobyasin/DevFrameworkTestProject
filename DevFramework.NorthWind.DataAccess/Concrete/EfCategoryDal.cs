using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.NorthWind.DataAccess.Abstract;
using DevFramework.NorthWind.DataAccess.Concrete.EntityFramework;
using DevFramework.NorthWind.Entities.Concrete;

namespace DevFramework.NorthWind.DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthWindContext>, ICategoryDal
    {
    }
}