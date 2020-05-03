using DevFramework.NorthWind.DataAccess.Concrete.NHibernate;
using DevFramework.NorthWind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.NorthWind.DataAccessTests
{
    [TestClass]
    public class NhibarnateTests
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NHProductDal productDal = new NHProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NHProductDal productDal = new NHProductDal(new SqlServerHelper());

            var result = productDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}