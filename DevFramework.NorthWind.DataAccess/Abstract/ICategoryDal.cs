using DevFramework.Core.DataAccess;
using DevFramework.NorthWind.Entities.Concrete;

namespace DevFramework.NorthWind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}