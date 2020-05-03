using DevFramework.NorthWind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.NorthWind.Entities.Concrete;
using System.Data.Entity;

namespace DevFramework.NorthWind.DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext()
        {
            Database.SetInitializer<NorthWindContext>(null); // code dan db oluşturmayı engellemek için yapıldı
        }

        public DbSet<Product> Products { get; set; }
        //diğer entity ler için db setleri oluşturmak gerekiyor

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());// map ettiğimiz mapper ları buraya tanımladık
        }
    }
}