using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadCost_SetsPriceOfBread_Int()
        {
            int breadAmount = 5;
            int shouldCost = 20;
            Bread boughtBread = new Bread();
            boughtBread.BreadCost(breadAmount);
            Assert.AreEqual(shouldCost, boughtBread.BreadPrice);
        }
    }

    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryCost_SetsPriceOfBread_Int()
        {
            int pastryAmount = 5;
            int shouldCost = 9;
            Pastry boughtPastry = new Pastry();
            boughtPastry.PastryCost(pastryAmount);
            Assert.AreEqual(shouldCost, boughtPastry.PastryPrice);
        }
    }

    [TestClass]
    public class DonutTests
    {
        [TestMethod]
        public void DonutCost_SetsPriceOFDonut_Int()
        {
            int donutAmount = 12;
            int shouldCost = 10;
            Donut boughtDonuts = new Donut();
            boughtDonuts.DonutCost(donutAmount);
            Assert.AreEqual(shouldCost, boughtDonuts.DonutPrice);
        }
    }
}