using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.NorthWind.DataAccess.Abstract;
using DevFramework.NorthWind.Entities.ComplexTypes;
using DevFramework.NorthWind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DevFramework.NorthWind.DataAccess.Concrete.NHibernate
{
    public class NHProductDal : NHEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;

        public NHProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
            //base(nHibernateHelper) =>  NHProductDal initialize edildiğinde, base class ına dependency olarak gelen
            // "nHibernateHelper" ı iletir. Base (NHEntityRepositoryBase) içerisinde de bu kullanılır.
        }

        public List<ProductDetail> GetDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}