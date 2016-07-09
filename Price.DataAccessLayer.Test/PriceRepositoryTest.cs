using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Price.DataAccessLayer.Test
{
    [TestClass]
    public class PriceRepositoryTest
    {
        private readonly PriceRepository _priceRepository = new PriceRepository();
        [TestMethod]
        public void Insert_Success()
        {
            _priceRepository.Insert(16031100025, "Error msg injected");
        }

        [TestMethod]
        public void Get_Success()
        {
           var result = _priceRepository.Get();
        }
    }
}
