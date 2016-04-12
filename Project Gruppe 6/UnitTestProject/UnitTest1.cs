using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlerLayer;
using ModelLayer;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int beginning = 10;
            int creditAmount = 10;
            int expected = 20;
            int x = 0;
            //act
            x = beginning + creditAmount;
            //assert
            Assert.AreEqual(expected, x, 0);
        }
        [TestMethod]
        public void CPUtest()
        {
            //arrange 
            ModelLayer.Hardware.CPU cpu = new ModelLayer.Hardware.CPU();

            //act
            cpu.BaseClock = 1;

            //assert
            Assert.AreEqual(1, cpu.BaseClock, 0);
        }



    }
}
