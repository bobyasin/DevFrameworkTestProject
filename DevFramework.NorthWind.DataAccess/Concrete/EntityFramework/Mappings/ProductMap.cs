using DevFramework.NorthWind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.NorthWind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product> // mapping  için kullanıyouz. implement ediyoruz
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductId"); // tabloyu map ediyoruz
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}