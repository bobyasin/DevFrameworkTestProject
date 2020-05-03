using NHibernate;
using System;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory; // entity framwork teki context kavramına benzer. Factory design pattern i şeklindedir.
                                                        // oracle için bir configurasyon gönderince oracle için session oluşturur. veya sql server ..

        public virtual ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory ?? (_sessionFactory = InitializeFactory());
            }
        }

        protected abstract ISessionFactory InitializeFactory(); // bu helper ı implemente edenler, factory yi kendileri oluşturup

        //yollasın diye abstract yapıldı. sadece implemente eden kullansın diye protected yapıldı

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}