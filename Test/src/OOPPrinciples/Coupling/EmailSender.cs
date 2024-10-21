using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.OOPPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            //Email sending logic
            System.Console.WriteLine("Sending email: " + message);        }
    }
}