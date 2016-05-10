using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlLayer;
using DBLayer;
using System.Linq;
using System.Collections.Generic;
using ControlerLayer;

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
            var ctr = new HardwererCtr();
            ModelLayer.CPUTestClase CPU1 = new ModelLayer.CPUTestClase();
            ModelLayer.CPUTestClase CPU2 = new ModelLayer.CPUTestClase();
            ModelLayer.CPUTestClase CPU3 = new ModelLayer.CPUTestClase();

            //Act
            db.CPUTestClas.Add(CPU1);
            db.CPUTestClas.Add(CPU2);
            db.CPUTestClas.Add(CPU3);
            db.SaveChanges();
            IEnumerable<ModelLayer.CPUTestClase> cpulist = ctr.FindAllCPUs2().ToList();

            //Assert
            Assert.IsTrue(cpulist.Count() > 0);
        }

        [TestMethod]
        public void CreatCPU()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                //Arrange
                var ctr = new ProductCtr();

                //Act
                ModelLayer.Hardware.CPU CPU = new ModelLayer.Hardware.CPU
                {
                    //CPUId = 5,
                    ModelNumber = "I5 6600",
                    SocketId = 1
                };
                ctr.CreatCPU(CPU);
                db.CPUs.Add(CPU);
                db.SaveChanges();

                //Assert
                Assert.AreEqual("I5 6600", CPU.ModelNumber);
            }
        }
    }
}
