using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            using (DBLayer.EntityFrameworkContext db = new DBLayer.EntityFrameworkContext())
            {
                //arrange 
                ModelLayer.Hardware.CPU cpu = new ModelLayer.Hardware.CPU();

                //act
                cpu.BaseClock = 1;
                cpu.id = 2;
                db.CPUs.Add(cpu);
                db.SaveChanges();
                
                //assert
                Assert.AreEqual(1, cpu.BaseClock, 0,"shit failed is" + cpu.BaseClock);
            }

        }



    }
}
