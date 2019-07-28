using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTest
    {
        Bread testBread = new Bread();
        [TestMethod]
        public void ConstructorTest_True()
        {

            Assert.AreEqual(typeof(Bread), testBread.GetType());
        }
        [TestMethod]
        public void SingleLoaf_BreadCostTest()
        {
            int costForOneLoaf = testBread.CalculateBreadCost(1);
            Assert.AreEqual(5, costForOneLoaf);
        }

        [TestMethod]
        public void ThreeLoaf_BreadCostTest()
        {
            int costThreeLoaf = testBread.CalculateBreadCost(3);
            Assert.AreEqual(10, costThreeLoaf);
        }

        [TestMethod]
        public void TenLoaf_BreadCostTest()
        {
            int tenLoaf = testBread.CalculateBreadCost(10);
            Assert.AreEqual(35, tenLoaf);
        }
    }
}