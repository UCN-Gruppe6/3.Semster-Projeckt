using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class CostumerTEST
    {
        // Test metode til at lave en kunde.
        [TestMethod]
        public void CreatCostumer()
        {
            using (DBLayer.EntityFrameworkContext db = new DBLayer.EntityFrameworkContext())
            {
                //Arranger

                var costumerCtr = new ControlerLayer.CostumerCtr();

                //Act

                ModelLayer.Costumer costumer = new ModelLayer.Costumer()
                {
                    Name = "BO"
                };
                costumerCtr.CreatCostumer(costumer);
                db.Costumer.Add(costumer);
                db.SaveChanges();

                //Assert

                Assert.AreEqual("BO", costumer.Name);
            }
        }

        // Test metode til at finde en kunde via navn.
        // Dette er en midligtigt metode.
        [TestMethod]
        public void FindCostumerByName()
        {
            //Arranger

            var nameImput = "HANS";
            var db = new DBLayer.EntityFrameworkContext();
            var costumerCtr = new ControlerLayer.CostumerCtr();
            ModelLayer.Costumer costumer = new ModelLayer.Costumer
            {
                Name = "HANS"
            };

            //Act

            db.Costumer.Add(costumer);
            db.SaveChanges();
            IEnumerable<ModelLayer.Costumer> costumerList = costumerCtr.FindCostumerByName(nameImput);

            //Assert

            Assert.AreEqual("HANS", costumerList.First().Name);
        }

        [TestMethod]
        public void UpdateCostumer()
        {
            //Arranger

            var db = new DBLayer.EntityFrameworkContext();
            var costumerCtr = new ControlerLayer.CostumerCtr();
            ModelLayer.Costumer costumer = new ModelLayer.Costumer
            {
                Name = "JENS"
            };
            db.Costumer.Add(costumer);
            db.SaveChanges();

            //Act

            costumer.Name = "PETER";
            costumerCtr.UpdateCostumer(costumer);
            db.SaveChanges();

            //Assert

            Assert.AreNotEqual("JENS", costumer.Name);
        }

        [TestMethod]
        public void DeleteCostumer()
        {
            //Arranger

            var idImput = 1;
            var db = new DBLayer.EntityFrameworkContext();
            var customerCtr = new ControlerLayer.CostumerCtr();
            ModelLayer.Costumer customer = new ModelLayer.Costumer()
            {
                CostumerId = 1
            };
            db.Costumer.Add(customer);
            db.SaveChanges();

            //Act

            customerCtr.DeleteCostumer(idImput);
            db.SaveChanges();
            customerCtr.FindCustomerById(idImput);

            //Assert

            Assert.IsTrue(customerCtr.FindCustomerById(idImput) == null);
        }
    }
}
