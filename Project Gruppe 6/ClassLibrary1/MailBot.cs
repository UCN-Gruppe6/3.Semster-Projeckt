using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Basket;
using ModelLayer.Hardware;
using System.Net;
using System.Net.Mail;

namespace Mailbot
{
    public class MailBot
    {
        public void SendInvoiceMail(Basket basket)
        {
            if (basket.MyCustomer != null && basket.MyCustomer.Email != null)
                SendInvoiceMail(basket, basket.MyCustomer.Email);

        }


        public void SendInvoiceMail(Basket basket, String ToAddress)
        {
            try
            {
                const string FromAddress = "KlostRobot@gmail.com";
                const string FromPassword = "RobotRobot1";
                string subject = "Invoice ";
                string body = "";

                if (basket != null)
                {
                    double sum = 0;
                    if (basket.MyComputerCase != null)
                    {
                        body += String.Format("æ kass \n");
                        sum += basket.MyComputerCase.Price;
                    }
                    if (basket.MyCpu != null)
                    {
                        body += string.Format("{0} {1}: {2},- kr \n", (string)basket.MyCpu.Brand, (string)basket.MyCpu.Description, (string)basket.MyCpu.Price.ToString());
                        sum += basket.MyCpu.Price;
                    }

                    if (basket.MyGpu != null)
                    {
                        body += string.Format("{0} {1}: {2},- kr \n", basket.MyGpu.Manufacturer, basket.MyGpu.Model, basket.MyGpu.Price.ToString());
                        sum += basket.MyGpu.Price;
                    }
                    if (basket.MyMotherboard != null)
                    {
                        body += String.Format("moderkort \n");
                        sum += basket.MyMotherboard.Price;
                    }
                    if (basket.MyRam != null)
                    {
                        body += String.Format("ram  \n");
                        sum += basket.MyRam.Price;
                    }
                    if (basket.MyStorage != null)
                    {
                        body += String.Format("ornli' syg fastpladelager \n");
                        sum += basket.MyStorage.Price;
                    }

                    body += string.Format("Total: {0}", sum);
                }





                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");
                mail.From = new MailAddress(FromAddress);
                mail.To.Add(ToAddress);
                //mail.To.Add("Tinsfeldt88@gmail.com");
                //mail.To.Add();
                mail.Subject = subject;
                mail.Body = body;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(FromAddress, FromPassword);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

            }
            catch (Exception e)
            {
                throw e;
            }
        }







    }
}
