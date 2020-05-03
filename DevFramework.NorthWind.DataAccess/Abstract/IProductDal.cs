using DevFramework.Core.DataAccess;
using DevFramework.NorthWind.Entities.ComplexTypes;
using DevFramework.NorthWind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.NorthWind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // neden IProductDal diye bir interface yaptık? çünkü ürüne özgü metotlar içerebilir. SOLID = I (interface segregation)

        List<ProductDetail> GetDetails();
    }
}