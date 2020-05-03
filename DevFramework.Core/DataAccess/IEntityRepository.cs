using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new() // class yollanabilecek, new lenebilecek. Abstract Interface yollanamayacak. Buna engel olması için bu kısıt eklendi.
    {
        // generic çalışacak bir model oluşturduk. Entity framework, nhibernate gibi orm araçlarında kullanılabilmesi için

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);// entity yi yolluyoruz, çünkü PK alanına göre sileceği için ve bu PK veri tipi değişkenlik gösterebileceği için entity yi yolladık
    }
}