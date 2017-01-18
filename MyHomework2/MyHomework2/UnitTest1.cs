using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyHomework2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_One_Volume_1_Price_Should_Be_100()
        {
            var cart = new Cart();
            cart.add(new Book(volume = 1, price = 100));
            var expected = 100;
            Assert.AreEqual(expected, cart.checkout());
        }
    }
}
