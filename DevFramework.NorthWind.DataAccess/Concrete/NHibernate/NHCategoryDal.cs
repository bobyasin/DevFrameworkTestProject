using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.NorthWind.DataAccess.Abstract;
using DevFramework.NorthWind.Entities.Concrete;

namespace DevFramework.NorthWind.DataAccess.Concrete.NHibernate
{
    public class NHCategoryDal : NHEntityRepositoryBase<Category>, ICategoryDal
    {
        public NHCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}