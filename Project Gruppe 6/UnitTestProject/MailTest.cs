using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;
using Mailbot;
using ModelLayer.Basket;
using ModelLayer.Hardware;

namespace UnitTestProject
{
    [TestClass]
    public class MailTest
    {
        [TestMethod]
        public void SendTestMailTilEmil()
        {
            if(true)
            {
                try
                {
                    Basket basket = new Basket();
                    basket.MyCpu = new CPU() {Brand = "TestBrand", Description = "i9-1337", Price = 1337};
                    basket.MyGpu = new GPU() {Manufacturer = "TestManu", Model = "GTX1337", Price = 1337};
                    MailBot mailbot = new MailBot();
                    
                    mailbot.SendInvoiceMail(basket, "Emil.kloster.lindberg@gmail.com");
                }
                catch(Exception e)
                {
                    throw e;
                }

            }
            Assert.AreEqual(1, 1, "yo");
        }


    }
}
