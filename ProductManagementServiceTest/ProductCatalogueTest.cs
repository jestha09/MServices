using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductCatalogue.DataAccessLayer.Test
{
    [TestClass]
    public class ProductCatalogueTest
    {
        [TestMethod]
        public void GetStatus_Success()
        {
            var repo = new ProductCatalogueContext();
            var result = repo.Status.FirstOrDefault();
        }
    }
}
