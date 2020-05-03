using DevFramework.NorthWind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.NorthWind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName"); // tabloyu map ediyoruz
        }
    }
}