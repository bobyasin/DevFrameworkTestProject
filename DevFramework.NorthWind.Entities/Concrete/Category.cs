using DevFramework.Core.Entities;

namespace DevFramework.NorthWind.Entities.Concrete
{
    public class Category : IEntity
    {
        // NHibarnate kullanımı için virtual ekledik.
        public virtual int CategoryId { get; set; }

        public virtual string CategoryName { get; set; }
    }
}