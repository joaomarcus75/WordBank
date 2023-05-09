using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordBank.Library.Email
{
    public class Constants
    {
        //pop 3, imap - read e-mail messages 
        //smtp - send e-mailx

        //autentication - gmail

        public readonly static string User = " "; // your email
        public readonly static string Password = " "; //your password

        //server smtp

        public readonly static string SMTPServer ="smtp.gmail.com";
        public readonly static int SMTPPort = 587;
    }
}
