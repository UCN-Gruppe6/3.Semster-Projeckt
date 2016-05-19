//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace UnitTestProject
//{
//    [TestClass]
//    public class BasketTEST
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            //Arrange
//            var db = new DBLayer.EntityFrameworkContext();
//            var Bctr = new ControlerLayer.BasketCtr();
//            var Hctr = new ControlerLayer.HardwererCtr();
//            ModelLayer.Hardware.CPU CPU = new ModelLayer.Hardware.CPU
//            {
//                ModelNumber = "I5 6400",
//                SocketId = 1,
//                Stock = 10
//            };
//            db.CPUs.Add(CPU);
//            db.SaveChanges();

//            //Act
//            Hctr.FindCPUbyModelNr("I5 6400");
//            Bctr.AddCPUtoBasket("I5 6400");
//            db.SaveChanges();

//            //Assert
//            Assert.AreNotEqual(10, CPU.Stock);


//       }
//    }
//}

