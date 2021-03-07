using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void Constructor_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadCost_SetsPriceOfBreadWithDiscount_Int()
        {
            int breadAmount = 3;
            int shouldCost = 10;
            Bread boughtBread = new Bread();
            boughtBread.BreadCost(breadAmount);
            Assert.AreEqual(shouldCost, boughtBread.BreadPrice);
        }

        [TestMethod]
        public void BreadCost_SetsPriceOfBread_Int()
        {
            int breadAmount = 1;
            int shouldCost = 5;
            Bread boughtBread = new Bread();
            boughtBread.BreadCost(breadAmount);
            Assert.AreEqual(shouldCost, boughtBread.BreadPrice);
        }
    }

    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void Constructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void PastryCost_SetsPriceOfPastryWithDiscount_Int()
        {
            int pastryAmount = 5;
            int shouldCost = 9;
            Pastry boughtPastry = new Pastry();
            boughtPastry.PastryCost(pastryAmount);
            Assert.AreEqual(shouldCost, boughtPastry.PastryPrice);
        }

        [TestMethod]
        public void PastryCost_SetsPriceOfPastry_Int()
        {
            int pastryAmount = 1;
            int shouldCost = 2;
            Pastry boughtPastry = new Pastry();
            boughtPastry.PastryCost(pastryAmount);
            Assert.AreEqual(shouldCost, boughtPastry.PastryPrice);
        }
    }

    [TestClass]
    public class DonutTests
    {
        [TestMethod]
        public void Constructor_CreatesInstanceOfDonut_Donut()
        {
            Donut newDonut = new Donut();
            Assert.AreEqual(typeof(Donut), newDonut.GetType());
        }

        [TestMethod]
        public void DonutCost_SetsPriceOfDonutWithDiscount_Int()
        {
            int donutAmount = 12;
            int shouldCost = 10;
            Donut boughtDonuts = new Donut();
            boughtDonuts.DonutCost(donutAmount);
            Assert.AreEqual(shouldCost, boughtDonuts.DonutPrice);
        }

        [TestMethod]
        public void DonutCost_SetsPriceOfDonut_Int()
        {
            int donutAmount = 1;
            int shouldCost = 2;
            Donut boughtDonuts = new Donut();
            boughtDonuts.DonutCost(donutAmount);
            Assert.AreEqual(shouldCost, boughtDonuts.DonutPrice);
        }
    }
}