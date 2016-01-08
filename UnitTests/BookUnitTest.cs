using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookApp;

namespace UnitTests
{
    [TestClass]
    public class BookUnitTest
    {
       
        [TestMethod]
        public void UpdatePriceByPercent_ChangeValue_ReturnPriceTimesPercent()
        {
            var b = new Book {Price = 10};
            b.UpdatePriceByPercent(.05M);
            Assert.AreEqual(10M*.05M, b.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SaveBook_ChangeValue_PriceNegative()
        {
            var b = new Book {Price = -1};
            b.SaveBook();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SaveBook_ChangeValue_PriceHigher()
        {
            var b = new Book {Price = 98};
            b.SaveBook();
        }
    }
}
