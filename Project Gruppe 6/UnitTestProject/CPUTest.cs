using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlerLayer;
using DBLayer;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class CPUTest
    {
        [TestMethod]
        public void CPUTest1()
        {
            using (DBLayer.EntityFrameworkContext db = new DBLayer.EntityFrameworkContext())
            {
                //arrange 
                ModelLayer.Hardware.CPU cpu = new ModelLayer.Hardware.CPU();

                //act
                cpu.BaseClock = 1;
                cpu.CPUId = 2;
                db.CPUs.Add(cpu);
                db.SaveChanges();

                //assert
                Assert.AreEqual(1, cpu.BaseClock, 0, "shit failed is" + cpu.BaseClock);
            }
        }

        [TestMethod]
        public void FindAllCPUsByBrandTest()
        {
            //Arranger
            var brandInput = "Brand";
            var db = new EntityFrameworkContext();
            var hrdweCtr = new HardwererCtr();
            ModelLayer.Hardware.CPU CPU = new ModelLayer.Hardware.CPU
            {
                Brand = "Brand"
            };

            //Act
            db.CPUs.Add(CPU);
            db.SaveChanges();
            IEnumerable<ModelLayer.Hardware.CPU> cpuList = hrdweCtr.FindCPUsByBrand(brandInput).ToList();

            //Assert
            Assert.AreEqual("Brand", cpuList.First().Brand);
        }

        [TestMethod]
        public void FindAllCPUsByCategory()
        {
            //Arranger
            var category = "Gaming";
            var db = new EntityFrameworkContext();
            var hrdweCtr = new HardwererCtr();
            ModelLayer.Hardware.CPU CPU = new ModelLayer.Hardware.CPU
            {
                Category = "Gaming"
            };

            //Act
            db.CPUs.Add(CPU);
            db.SaveChanges();
            IEnumerable<ModelLayer.Hardware.CPU> cpulist = hrdweCtr.FindCPUsByCategory(category).ToList();

            //Assert
            Assert.AreEqual("Gaming", cpulist.First().Category);
        }

        [TestMethod]
        public void FindAllCPUs()
        {
            //Arrange
            var db = new EntityFrameworkContext();
            var hrdweCtr = new HardwererCtr();
            ModelLayer.Hardware.CPU CPU1 = new ModelLayer.Hardware.CPU();
            ModelLayer.Hardware.CPU CPU2 = new ModelLayer.Hardware.CPU();
            ModelLayer.Hardware.CPU CPU3 = new ModelLayer.Hardware.CPU();

            //Act
            db.CPUs.Add(CPU1);
            db.CPUs.Add(CPU2);
            db.CPUs.Add(CPU3);
            db.SaveChanges();
            IEnumerable<ModelLayer.Hardware.CPU> cpulist = hrdweCtr.FindAllCPUs().ToList();

            //Assert
            Assert.IsTrue(cpulist.Count() > 0);
        }
    }

}
