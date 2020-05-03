using DevFramework.NorthWind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.NorthWind.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProductId).Column("ProductID");

            Map(m => m.CategoryId).Column("CategoryId");
            Map(m => m.ProductName).Column("ProductName");
            Map(m => m.QuantityPerUnit).Column("QuantityPerUnit");
            Map(m => m.UnitPrice).Column("UnitPrice");
        }
    }
}