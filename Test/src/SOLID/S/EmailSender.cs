using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID
{
    public class EmailSender
    {
        public void SendEmail(string email, string message){
            System.Console.WriteLine("Sending email to " + email + ": " + message);
        }
    }
}