using DevFramework.NorthWind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.NorthWind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");

            Map(m => m.CategoryName).Column("CategoryName");
        }
    }
}