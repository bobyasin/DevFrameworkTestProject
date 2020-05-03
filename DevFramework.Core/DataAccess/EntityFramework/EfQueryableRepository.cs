using DevFramework.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new() // burada where keyword ü ile ksııt koyuyoruz (deffesive yaklaşım)
    {
        // context i kapatmadan birden fazla işlem yaparak arka arkaya yapılan işlemler için kullanılabilir.
        // örneğin ODATA işlemleri

        private DbContext _dbContext;
        private IDbSet<T> _entities; // bir tablo entity framework te DbSet e denk gelir.

        public EfQueryableRepository(DbContext dbContext) // dependency injection işlemi yapıldı. birden farklı context gelebilir.
        {
            _dbContext = dbContext;// business katmanının herhangi bir context e bağlı olmasını engelleyecek
        }

        public IQueryable<T> Table { get; }

        protected virtual IDbSet<T> Entites // new leyen başka sınıflar kullanamasın diye protected yaptık.
        {
            // virtual : bütün ORM lerde lazy load yapabilmek için gerekli imza
            get
            {
                return _entities ?? (_entities = _dbContext.Set<T>()); //
            }
        }
    }
}