using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.OOPPrinciples.Coupling
{
    public class SMSSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("SMS message: " + message);
        }
    }
}