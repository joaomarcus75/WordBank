using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WordBank.Models;

namespace WordBank.Library.Email
{
    public class SendEmail
    {
        public static void SendContactMessage(Contact contact)
        {
            string content = string.Format("Name: {0}</br> E-mail: {1}</br> Subject: {2}</br> Message: {3}", contact.Name, contact.Email, contact.Subject, contact.Message);
            //Configure SMTP server
            SmtpClient smtp = new SmtpClient(Constants.SMTPServer,Constants.SMTPPort);
            smtp.EnableSsl = true;
            
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.User,Constants.Password);

            //Email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("joaomarcus75@gmail.com");
            message.To.Add("joaomarcus75@gmail.com");
            message.Subject = "Contact Form";

            message.IsBodyHtml = true;
            message.Body = "<h1> Contact Form </h1>" + content;

            smtp.Send(message);
        }
    }
}
