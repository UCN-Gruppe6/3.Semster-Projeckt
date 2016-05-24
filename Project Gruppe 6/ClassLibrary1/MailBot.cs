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

        public void SendInvoiceMail(Basket basket, String ToAddress )
        {
            try {
                const string FromAddress = "KlostRobot@gmail.com";
                const string FromPassword = "RobotRobot1";
                string subject = "Order nr: ";
                string body = "Test";

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");
                mail.From = new MailAddress(FromAddress);
                mail.To.Add(ToAddress);
                mail.Subject = subject;
                mail.Body = body;
                SmtpServer.Port = 465;
                SmtpServer.Credentials = new System.Net.NetworkCredential(FromAddress, FromPassword);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

            }
            catch(Exception e)
            {
                
            }
        }







    }
}
