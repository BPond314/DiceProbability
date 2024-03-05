using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatestCommonDivisor;

namespace GCDTests
{
    [TestClass]
    public class GCDTests
    {
        [TestMethod]
        public void BasicGCD()
        {
            Assert.AreEqual(3, GCD.GCDAlgorithm(27, 6));
        }

        [TestMethod]
        public void PrimeGCD()
        {
            Assert.AreEqual(1, GCD.GCDAlgorithm(31, 97));
        }
    }
}