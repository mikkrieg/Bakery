using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Donut;
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
            int breadAmount = 5;
            int shouldCost = 20;
            Loaves boughtBread = new Loaves();
            boughtBread.BreadCost(breadAmount);
            Assert.AreEqual(shouldCost, boughtBread.BreadPrice);
        }
    }

    [TestClass]
    public class PastriesTests
    {
        [TestMethod]
        public void PastryCost_SetsPriceOfBread_Int()
        {
            int pastryAmount = 5;
            int shouldCost = 9;
            Pastries boughtPastry = new Pastries();
            boughtPastry.PastryCost(pastryAmount);
            Assert.AreEqual(shouldCost, boughtPastry.PastryPrice);
        }
    }

    [TestClass]
    public class DonutsTests
    {
        [TestMethod]
        public void DonutCost_SetsPriceOFDonut_Int()
        {
            int donutAmount = 12;
            int shouldCost = 10;
            Donuts boughDonuts = new Donuts();
            boughDonuts.DonutCost(donutAmount);
            Assert.AreEqual(shouldCost, boughDonuts.DonutPrice);
        }
    }
}