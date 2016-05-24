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
                Basket basket = new Basket();
                MailBot mailbot = new MailBot();

                mailbot.SendInvoiceMail(basket, "Emil.kloster.lindberg@gmail.com");
            }



            Assert.AreEqual(1, 1, "yo");
        }
    }
}
