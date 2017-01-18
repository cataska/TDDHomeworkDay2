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
            cart.add(new Book() {volume = 1, price = 100});
            var expected = 100;
            Assert.AreEqual(expected, cart.checkout());
        }

        [TestMethod]
        public void Test_One_Volume_1_One_Volume_2_Price_Should_Be_190()
        {
            var cart = new Cart();
            cart.add(new Book() { volume = 1, price = 100 });
            cart.add(new Book() { volume = 2, price = 100 });
            var expected = 190;
            Assert.AreEqual(expected, cart.checkout());
        }

        [TestMethod]
        public void Test_One_Volume_1_One_Volume_2_One_Volume_3_Price_Should_Be_270()
        {
            var cart = new Cart();
            cart.add(new Book() { volume = 1, price = 100 });
            cart.add(new Book() { volume = 2, price = 100 });
            cart.add(new Book() { volume = 3, price = 100 });
            var expected = 270;
            Assert.AreEqual(expected, cart.checkout());
        }
    }
}
