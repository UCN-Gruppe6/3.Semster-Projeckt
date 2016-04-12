using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int beginning = 10;
            int creditAmount = 10;
            int expected = 20;
            int x = 0;

            x = beginning + creditAmount;

            Assert.AreEqual(expected, x, 0);
        }
    }
}
