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

            //Act

            db.Costumer.Add(costumer);
            db.SaveChanges();


            //Assert
        }

        [TestMethod]
        public void DeleteCostumer()
        {
            //Arranger

            //Act

            //Assert
        }
    }
}
