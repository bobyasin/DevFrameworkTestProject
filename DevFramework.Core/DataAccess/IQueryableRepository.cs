using DevFramework.Core.Entities;
using System.Linq;

namespace DevFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new() // class => Referans tipi olduğunu belirtir.
    {
        // IQueryble işlemlerin özellikle business tarafında context kapatılmadan çalıştırılabilmesi için ekledik bu interface i
        IQueryable<T> Table { get; }
    }
}