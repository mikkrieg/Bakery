using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;
using Bakery.Bread;
using Bakery.Pastry;

namespace Bakery.Tests
{
    [TestClass]
    public class LoavesTests
    {
        [TestMethod]
        public void BreadCost_SetsPriceOfBread_Int()
        {
            int bread = 5;
            int shouldCost = 20;
            Loaves boughtBread = new Loaves();
            int result = boughtBread.BreadCost(bread);
            Assert.AreEqual(shouldCost, result);
        }
    }

    [TestClass]
    public class PastriesTests
    {

    }
}