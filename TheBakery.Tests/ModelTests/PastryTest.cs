using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTest
    {
        Pastry testPastry = new Pastry();
        [TestMethod]
        public void ConstructorTest_True()
        {
            Assert.AreEqual(typeof(Pastry), testPastry.GetType());
        }
        [TestMethod]
        public void SingleLoaf_BreadCostTest()
        {
            int costForOneLoaf = testPastry.CalculatePastryCost(1);
            Assert.AreEqual(2, costForOneLoaf);
        }

        [TestMethod]
        public void ThreeLoaf_BreadCostTest()
        {
            int costForThreeLoaf = testPastry.CalculatePastryCost(3);
            Assert.AreEqual(5, costForThreeLoaf);
        }

        [TestMethod]
        public void TenLoaf_BreadCostTest()
        {
            int costForTenLoaf = testPastry.CalculatePastryCost(10);
            Assert.AreEqual(17, costForTenLoaf);
        }

    }
}