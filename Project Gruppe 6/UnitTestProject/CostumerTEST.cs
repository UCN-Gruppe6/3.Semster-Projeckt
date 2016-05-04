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
        public void CreateCustomer()
        {
            using (DBLayer.EntityFrameworkContext db = new DBLayer.EntityFrameworkContext())
            {
                //Arranger

                var customerCtr = new ControlLayer.CustomerCtr();

                //Act

                ModelLayer.Customer customer = new ModelLayer.Customer()
                {
                    Name = "BO"
                };
                customerCtr.CreatCostumer(customer);
                db.Costumer.Add(customer);
                db.SaveChanges();

                //Assert

                Assert.AreEqual("BO", customer.Name);
            }
        }

        // Test metode til at finde en kunde via navn.
        // Dette er en midligtigt metode.
        [TestMethod]
        public void FindCustomerByName()
        {
            //Arranger

            var nameInput = "HANS";
            var db = new DBLayer.EntityFrameworkContext();
            var customerCtr = new ControlLayer.CustomerCtr();
            ModelLayer.Customer customer = new ModelLayer.Customer
            {
                Name = "HANS"
            };

            //Act

            db.Costumer.Add(customer);
            db.SaveChanges();
            IEnumerable<ModelLayer.Customer> costumerList = customerCtr.FindCostumerByName(nameInput);

            //Assert

            Assert.AreEqual("HANS", costumerList.First().Name);
        }

        [TestMethod]
        public void UpdateCostumer()
        {
            //Arranger

            var db = new DBLayer.EntityFrameworkContext();
            var costumerCtr = new ControlLayer.CustomerCtr();
            ModelLayer.Customer costumer = new ModelLayer.Customer
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
